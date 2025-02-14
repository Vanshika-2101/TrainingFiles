use AdventureWorks2017_003; 

select BusinessEntityID, NationalIDNumber 
from HumanResources.Employee  
where NationalIDNumber = '998320692'; 
 
set statistics io on; 
select NationalIDNumber, JobTitle, HireDate 
from HumanResources.Employee 
where NationalIDNumber = '998320692'; 
 
--Table 'Employee'. Scan count 0, logical reads 4, physical reads 0 
 
--Creating composite index 
create unique index [AK_Employee_NationalIDNumber] 
on HumanResources.Employee(NationalIDNumber, JobTitle, HireDate) 
with drop_existing;

--Table 'Employee'. Scan count 1, logical reads 2, physical reads 0
 
--Creating covering index 
create unique index [AK_Employee_NationalIDNumber]  
on HumanResources.Employee(NationalIDNumber)  
include(JobTitle, HireDate) 
with drop_existing; 
--Table 'Employee'. Scan count 1, logical reads 6, physical reads 0

-- Performance tuning means reducing scans

-- Missing index
select City, StateProvinceID, PostalCode
from Person.Address
where StateProvinceID = 1;

-- By DMV
select * from sys.dm_db_missing_index_details;

create index IDX 
on person.address(stateprovinceid)
include(city, postalcode);

-- FILTERED INDEX
select BusinessEntityID, JobTitle, LoginID
from HumanResources.Employee
where JobTitle = 'Marketing Manager'; -- clustered index scan
-- Table 'Employee'. Scan count 1, logical reads 9

create index filtered_index
on HumanResources.Employee(businessentityid)
where JobTitle = 'Marketing Manager';

select BusinessEntityID, JobTitle, LoginID
from HumanResources.Employee
where JobTitle = 'Marketing Manager'; -- lookup
-- Table 'Employee'. Scan count 1, logical reads 4

create index filtered_index
on HumanResources.Employee(businessentityid)
include(loginid, jobtitle)
where JobTitle = 'Marketing Manager'
with drop_existing;

select BusinessEntityID, JobTitle, LoginID
from HumanResources.Employee
where JobTitle = 'Marketing Manager';  -- scan
-- Table 'Employee'. Scan count 1, logical reads 2


