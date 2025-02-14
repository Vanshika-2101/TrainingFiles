USE AdventureWorks2017;

SELECT * FROM HumanResources.Employee;
SELECT * FROM PERSON.PERSON

--BEID, --EMP NAME, JOBTITLE, DOB, DOJ, AGE, EXP, VH, SLH, TLH
SELECT HR.BusinessEntityID, 
	   CASE WHEN PP.MIDDLENAME IS NULL THEN CONCAT(PP.FirstName, ' ', PP.LastName)
	   ELSE CONCAT(PP.FirstName, ' ', PP.MiddleName, ' ', PP.LastName) END AS EMP_NAME,
	   HR.JobTitle, HR.BirthDate, HIREDATE AS DOJ, 
	   DATEDIFF(YYYY,HR.BirthDate,GETDATE()) AS AGE,
	   DATEDIFF(YYYY, HireDate,GETDATE()) AS EXP,
	   HR.VacationHours,
	   HR.SickLeaveHours,
	   VacationHours + SickLeaveHours AS TLH
FROM HumanResources.EMPLOYEE HR INNER JOIN PERSON.PERSON PP
ON HR.BusinessEntityID = PP.BusinessEntityID

SELECT * FROM Production.ProductCategory;
SELECT * FROM Production.ProductSubcategory;
SELECT * FROM Production.Product;


-- CATEGORY NAME, SUBCAT NAME, PDT NAME, STD PRICE, LIST PRICE, PROFIT
SELECT PC.Name AS [CATEGORY NAME], SC.NAME [SUBCATEGORY NAME], P.NAME [PRODUCT NAME], 
	   P.StandardCost, P.ListPrice, P.ListPrice - P.StandardCost AS PROFIT
FROM Production.ProductCategory PC INNER JOIN Production.ProductSubcategory SC
ON PC.ProductCategoryID = SC.ProductCategoryID
INNER JOIN Production.Product P
ON P.ProductSubcategoryID = SC.ProductSubcategoryID
ORDER BY 1, 2, 3;

SELECT * FROM HumanResources.Department;
SELECT * FROM HumanResources.Employee;

--> SCHEMA IS A COLLECTION OF OBJECTS
--> BEID, JOB-TITLE, HIREDATE, NAME, GROUP NAME
--> WE NEED A MAPPING/JUNCTION TABLE HERE
SELECT E.BusinessEntityID, E.JobTitle, E.HireDate, D.Name AS DEPARTMENT_NAME, D.GroupName
FROM HumanResources.EmployeeDepartmentHistory EDH INNER JOIN HumanResources.Employee E
ON EDH.BusinessEntityID = E.BusinessEntityID
INNER JOIN HumanResources.Department D
ON EDH.DepartmentID = D.DepartmentID
ORDER BY 1;



