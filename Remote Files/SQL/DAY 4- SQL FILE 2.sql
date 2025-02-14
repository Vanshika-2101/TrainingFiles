SELECT * FROM Production.Product;
select * from Production.WorkOrder;

--list of pdt ids who have work orders 
select productID
from Production.Product
intersect
select ProductID
from Production.WorkOrder

--list of pdt ids who don't have work orders
select productID
from Production.Product
except
select ProductID
from Production.WorkOrder


SELECT * FROM HumanResources.Employee;
SELECT * FROM HumanResources.Department;
SELECT * FROM Person.Person;
SELECT * FROM HumanResources.EmployeePayHistory;

SELECT D.GroupName, E.BusinessEntityID, E.JobTitle, E.HireDate,
	   P.FirstName, P.LastName, 
	   AVG(EPH.RATE) AS AVG_SAL 
FROM HumanResources.Department D INNER JOIN HumanResources.EmployeeDepartmentHistory EDH
ON D.DepartmentID = EDH.DepartmentID
INNER JOIN HumanResources.Employee E
ON E.BusinessEntityID = EDH.BusinessEntityID
INNER JOIN PERSON.Person P
ON E.BusinessEntityID = P.BusinessEntityID
INNER JOIN HumanResources.EmployeePayHistory EPH
ON P.BusinessEntityID = EPH.BusinessEntityID
GROUP BY E.BusinessEntityID, D.GroupName, E.JobTitle, E.HireDate,
	   P.FirstName, P.LastName
ORDER BY E.BUSINESSENTITYID; --NOT A GOOD PRACTICE OFC


--USING CTE

WITH SALINFO
AS (SELECT BusinessEntityID, AVG(RATE) AS SALARY
	FROM HumanResources.EmployeePayHistory 
	GROUP BY BusinessEntityID)
SELECT D.GroupName, D.NAME, E.BusinessEntityID, E.JobTitle, E.HireDate,
	   P.FirstName, P.LastName, SALARY
FROM HumanResources.Department D INNER JOIN HumanResources.EmployeeDepartmentHistory EDH
ON D.DepartmentID = EDH.DepartmentID
INNER JOIN HumanResources.Employee E
ON E.BusinessEntityID = EDH.BusinessEntityID
INNER JOIN PERSON.Person P
ON E.BusinessEntityID = P.BusinessEntityID
INNER JOIN SALINFO S
ON P.BusinessEntityID = S.BusinessEntityID
ORDER BY E.BusinessEntityID;

--OR USING DERIVED TABLE
SELECT D.GroupName, D.NAME, E.BusinessEntityID, E.JobTitle, E.HireDate,
	   P.FirstName, P.LastName, SALARY
FROM HumanResources.Department D INNER JOIN HumanResources.EmployeeDepartmentHistory EDH
ON D.DepartmentID = EDH.DepartmentID
INNER JOIN HumanResources.Employee E
ON E.BusinessEntityID = EDH.BusinessEntityID
INNER JOIN PERSON.Person P
ON E.BusinessEntityID = P.BusinessEntityID
INNER JOIN (SELECT BusinessEntityID, AVG(RATE) AS SALARY
	FROM HumanResources.EmployeePayHistory 
	GROUP BY BusinessEntityID) S
ON P.BusinessEntityID = S.BusinessEntityID
ORDER BY E.BusinessEntityID;

