										-------> INDEXES <---------
-- It is used to enhance the performance of a query. (Provided if created correctly)

-- There are two types of indexes:
--   1. Clustered Index
--			a. It holds the data of entire table
--			b. Table can only have one clustered index. (because data is physically sorted and stored )
--			c. It is by default created when we create primary key on a table.
--	 2. Non-Clustered Index
--			a. Is a pointer to clustered index.
--			b. It holds the data of specific column(s).
--			c. Two types of non-clustered indexes:
--					i. Unique Non-Clustered Index
--					ii. Non-Unique Non-Clustered Index

-- When to create indexes?
--	 1. Create index on a column regularly used in the WHERE clause.
--	 2. Create index on a column used in JOIN conditions.
--	 3. Create index on a column used in HAVING clause.
--   4. Create composite index on columns used in WHERE clause.
--   5. Create covering / include index on a column used in SELECT statement.
--   6. Filter Index: 
--			a. It is index with WHERE clause.
--			b. It is created on the primary key column of the table.
--			c. It is mainly used in two scenaios:
--					i. When we are already aware what details end user will filter data on.
--					ii. When column have lots of NULL values
--   7. Column Store Index:

-- When not to create indexes?
--   1. On a small table.
--   2. On a column which is regularly updated.
--   3. On a column having lots of duplicates.
--   4. On a column having lots of NULL values. (If required, create filter index)

-- Note:- Every query has an execution plan. 
--       Optimizer is the part of the database engine which generates execution plan for queries using statistics.
-- Statistics is metadata of the indexes.


USE IVP3686;

--HEAP TABLE
CREATE TABLE Student
(
	SID INT NOT NULL,
	SName VARCHAR(20) NOT NULL,
	Branch VARCHAR(20),
	Marks FLOAT
);

INSERT INTO Student 
VALUES (10, 'Nikhil', 'ELECT', 95),
	   (20, 'Amit', 'CS', 90),
	   (30, 'Jack', 'IT', 85);

SELECT * FROM Student;

INSERT INTO Student 
VALUES (15, 'Neha', 'CS', 75),
	   (25, 'Nikhil', 'CS', 90),
	   (35, 'Amit', 'CS', 75);

SELECT * FROM Student;

-- To filter out result from large data, we need indexes.

SELECT * FROM Student WHERE SID = 10; -- TABLE SCAN

-- TABLE SCAN: Entire table is brought in the memory.
-- IOT : Index Organised Table (Table should have primary key or clustered index)

-- CREATING CLUSTERED INDEX
-- create unique clustered index <table name>_<column name>_<uci>
CREATE UNIQUE CLUSTERED INDEX Student_SID_UCI
ON Student(SID);

CREATE UNIQUE CLUSTERED INDEX Student_Branch_UCI
ON Student(Branch);  -- Cannot create more than one clustered index on table 'Student'. ERROR.

-- DIFFERENCE FROM PRIMARY KEY?? - IT ALLOWS ONE NULL VALUE; PRIMARY KEY DOES NOT

-- TO DELETE AN EXISTING INDEX : [ DROP INDEX Student_SID_UCI ON Student; ]

-- CLUSTERED INDEX SCAN: ENTIRE SORTED TABLE DATA IS BROUGHT IN THE MEMORY
-- CLUSTERED INDEX SEEK: IT FETCHES SPECIFIC RECORDS IN THE MEMORY USING CLUSTERED INDEX (ROW ID)
SELECT * FROM Student; -- CLUSTERED INDEX SCAN
SELECT * FROM Student WHERE SID = 10; -- CLUSTERED INDEX SEEK
SELECT * FROM Student WHERE SID > 20; -- CLUSTERED INDEX SEEK
SELECT * FROM Student WHERE SID IN (20, 30); -- CLUSTERED INDEX SEEK
SELECT * FROM Student WHERE SID * 2 = 20; -- CLUSTERED INDEX SCAN : NON SARGABLE

-- NON SARGABLE: INDEX EXISTS, BUT STILL ISN'T HELPING TO ENHANCE PERFORMANCE; SCAN INSTEAD OF SEEK

SELECT * FROM Student WHERE SID LIKE '%2%'; -- NON SARGABLE; LIKE SHOULD BE ONLY USED WITH CHARACTER COLUMNS. SCAN

SELECT * FROM Student WHERE Branch = 'IT'; -- SCAN BECAUSE INDEX DOES NOT EXIST ON BRANCH COL; THIS IS A LIMITATION OF CLUSTERED INDEX

INSERT INTO Student 
VALUES (17, 'Neha', 'IT', 50),
	   (23, 'Nikhil', 'CS', 50);

SELECT * FROM Student;


-- NON-CLUSTERED INDEX 

SELECT SID, Branch
FROM Student
WHERE Branch = 'IT';     -- CLUSTERED INDEX SCAN

-- CREATION
-- create index <table name>_<column name>_<nci>
CREATE INDEX Student_Branch_NCI
ON Student(Branch);

SELECT SID, Branch
FROM Student
WHERE Branch = 'IT';  -- INDEX SEEK (NON CLUSTERED)

INSERT INTO Student
VALUES (40, 'Sonia', 'ELECT',60);

CREATE INDEX Student_SName_NCI
ON Student(SName);

SELECT SID, SName
FROM Student
WHERE SName = 'Nikhil'; -- INDEX SEEK (NON CLUSTERED)


SELECT SID, SName
FROM Student
WHERE SName LIKE 'N%'; -- INDEX SEEK (NON CLUSTERED)

SELECT SID, SName
FROM Student
WHERE SName LIKE '%l'; -- INDEX SCAN (NON CLUSTERED)

-- NON-CLUSTERED INDEX SCAN: ENTIRE SORTED COLUMN DATA IS BROUGHT IN THE MEMORY
-- NON-CLUSTERED INDEX SEEK: IT FETCHES SPECIFIC RECORDS IN THE MEMORY USING NON-CLUSTERED INDEX (ROW ID)

SELECT SID, Branch, Marks
FROM Student
WHERE Branch = 'CS' AND Marks > 80;  -- CLUSTERED INDEX SCAN

-- RUNNING IT USING LOOKUP; TWO INDEXES

SELECT SID, Branch, Marks
FROM Student WITH(INDEX = [Student_Branch_NCI])
WHERE Branch = 'CS' AND Marks > 80; -- KEY LOOKUP(CLUSTERED) + NONCLUSTERED INDEX SEEK

-- SERVER CHOSE SCAN BECAUSE ITS A SMALL TABLE. 
-- USE OF WHICH OF THE GENERATED EXECUTION PLANS WILL HAPPEN, IS A SERVER DECISION AT RUN TIME.

-- COMPOSITE INDEX CREATION
CREATE INDEX Student_Branch_Marks_NCI
ON Student(Branch, Marks);

SELECT SID, Branch, Marks
FROM Student
WHERE Branch = 'CS' AND Marks > 80;		-- NON-CLUSTERED INDEX SEEK

CREATE INDEX Student_Marks_Branch_NCI
ON Student(Marks, Branch);

CREATE INDEX Student_SName_Marks_NCI
ON Student(SName, Marks);

SELECT SID, SName, Marks
FROM Student
WHERE SName = 'Nikhil' AND Marks > 80;

SELECT SID, SName, Marks
FROM Student WITH (INDEX = Student_SName_NCI)
WHERE SName = 'Nikhil' AND Marks > 80;    -- SEEK AND LOOKUP

SELECT SID, SName, Marks
FROM Student WITH (INDEX = Student_Marks_Branch_NCI)
WHERE SName = 'Nikhil' AND Marks > 80;    -- SEEK AND LOOKUP

-- Note:- In case of lookup in execution plan, use composite or covering index to remove scan.

-- COVERING INDEX

SELECT SID, SName, Marks
FROM Student
WHERE Branch = 'IT' AND Marks >= 60;  -- LOOKUP / SCAN

CREATE INDEX Student_Branch_Marks_NCI
ON Student(Branch, Marks)
INCLUDE(SName)
WITH DROP_EXISTING;

SELECT SID, SName, Marks
FROM Student
WHERE Branch = 'IT' AND Marks >= 60;  -- SEEK

CREATE INDEX Student_Marks_NCI
ON Student(Marks)
INCLUDE (SName, Branch);

SELECT SID, SName, Branch
FROM Student
WHERE Marks >= 60;    -- INDEX SEEK NON-CLUSTERED


SELECT E.EMPLOYEE_ID, E.LAST_NAME, E.SALARY, E.HIRE_DATE,
	   D.DEPARTMENT_ID, D.DEPARTMENT_NAME
FROM EMPLOYEES E INNER JOIN DEPARTMENTS D
ON E.DEPARTMENT_ID = D.DEPARTMENT_ID;		-- SCANS FOR E.DEPARTMENT_ID

CREATE INDEX EMPLOYEES_DEPARTMENT_ID_NCI
ON EMPLOYEES(DEPARTMENT_ID)
INCLUDE (LAST_NAME, SALARY, HIRE_DATE);

SELECT E.EMPLOYEE_ID, E.LAST_NAME, E.SALARY, E.HIRE_DATE,
	   D.DEPARTMENT_ID, D.DEPARTMENT_NAME
FROM EMPLOYEES E INNER JOIN DEPARTMENTS D
ON E.DEPARTMENT_ID = D.DEPARTMENT_ID;		-- SEEKS FOR EMPLOYEE TABLE NOW

SET STATISTICS IO ON;
SELECT EMPLOYEE_ID, LAST_NAME, SALARY, JOB_ID, HIRE_DATE
FROM EMPLOYEES
WHERE COMMISSION_PCT IS NOT NULL;
--Table 'EMPLOYEES'. Scan count 1, logical reads 4
--CLUSTERED INDEX SCAN

CREATE INDEX EMPLOYEES_FIDX
ON EMPLOYEES(EMPLOYEE_ID)
WHERE COMMISSION_PCT IS NOT NULL;

SELECT EMPLOYEE_ID, LAST_NAME, SALARY, JOB_ID, HIRE_DATE
FROM EMPLOYEES WITH (INDEX = EMPLOYEES_FIDX)
WHERE COMMISSION_PCT IS NOT NULL;
--Table 'EMPLOYEES'. Scan count 1, logical reads 72
--LOOKUP

CREATE INDEX EMPLOYEES_FIDX
ON EMPLOYEES(EMPLOYEE_ID)
INCLUDE(LAST_NAME, SALARY, JOB_ID, HIRE_DATE)
WHERE COMMISSION_PCT IS NOT NULL
WITH DROP_EXISTING;

SELECT EMPLOYEE_ID, LAST_NAME, SALARY, JOB_ID, HIRE_DATE
FROM EMPLOYEES WITH (INDEX = EMPLOYEES_FIDX)
WHERE COMMISSION_PCT IS NOT NULL;
--Table 'EMPLOYEES'. Scan count 1, logical reads 2
--NON CLUSTERED INDEX SCAN

--NON CLUSTERED INDEX SCAN IS ALWAYS BETTER THAN CLUSTERED INDEX SCAN

SELECT LAST_NAME, JOB_ID, HIRE_DATE
FROM EMPLOYEES;

CREATE INDEX EMPLOYEES_LN_JI_HD_NCI
ON EMPLOYEES(LAST_NAME, JOB_ID, HIRE_DATE);

DROP INDEX EMPLOYEES_LN_JI_HD_NCI ON EMPLOYEES;

---- COLUMN STORE INDEX ----
-- It works on ONE column ONE page architecture
-- It is used on tables having huge data.
-- It is used when joins and aggregations are performed on huge tables.
-- It uses vertipag technology to store data (Zip). 

-- Two types:
--		1. Non-Clustered CS Index: Started from SQL Server 2012: Is created on specific columns
--		2. Clustered CS Index: (CCS): Started frm SQL Server 2014
-- Limitation in older versions: Table on which we created NC CS Index used to make table read-only
-- This limitation was removed in SQL Server 2016


-- CLUSTERED COLUMN STORE INDEX
-- Is created on entire table.

CREATE TABLE PRODUCT
(
	PID INT PRIMARY KEY,
	PNAME VARCHAR(20) NOT NULL,
	PRICE FLOAT,
	PCATEGORY VARCHAR(20)
)

INSERT INTO PRODUCT
VALUES
(1, 'MOBILE', 5000, 'ELECTRONICS'),
(2, 'LAPTOP', 75000, 'ELECTRONICS'),
(3, 'CHAIR', 2000, 'FURNITURE');

SELECT * FROM PRODUCT;

CREATE CLUSTERED COLUMNSTORE INDEX PRODUCT_CCS_IDX
ON PRODUCT;

-- THESE SHOULD BE CREATED ON TABLES WHICH ARE STANDALONE, 
-- I.E. WHICH DO NOT HAVE ANY RELATIONS WITH ANY OTHER TABLES; 
-- OR ON A HEAP TABLE

SELECT PID, PNAME, PRICE
FROM PRODUCT
WHERE PCATEGORY = 'ELECTRONICS';

CREATE INDEX PRODUCT_PCAT_NCI
ON PRODUCT(PCATEGORY)
INCLUDE (PID, PNAME, PRICE);

-- A TABLE CANNOT HAVE MULTIPLE COLUMNSTORE INDEXES
-- A CLUSTERED COLUMNSTORE TABLE MAY HAVE NON CLUSTERED INDEXES ON IT



						-------------> USER DEFINED FUNCTIONS (UDF) <--------------

-- FUNCTION: IT IS A DATABASE OBJECT WHICH RETURNS A VALUE
-- UDF ARE AWLAYS USED AS A PART OF QUERY
-- THERE ARE TWO TYPES OF FUNCTIONS:
--		1. SCALAR FUNCTION: RETURNS SINGLE VALUE
--		2. TABLE VALUES FUNCTION: RETURNS RESULT SET (TABLE) 


--> SCALAR FUNCTIONS

SELECT EMPLOYEE_ID, LAST_NAME, SALARY, 
	   SALARY * 0.3 AS TAX, 
	   HIRE_DATE, JOB_ID, DEPARTMENT_ID
FROM EMPLOYEES
WHERE DEPARTMENT_ID = 50;

SELECT EMPLOYEE_ID, LAST_NAME, SALARY, 
	   SALARY * 0.3 AS TAX, 
	   HIRE_DATE, JOB_ID, DEPARTMENT_ID
FROM EMPLOYEES
WHERE EMPLOYEE_ID = 100;

CREATE FUNCTION FX_TAX (@DATA FLOAT)
RETURNS FLOAT
AS
BEGIN
	RETURN @DATA * 0.3
END;

SELECT [dbo].[FX_TAX](1000);

SELECT EMPLOYEE_ID, LAST_NAME, SALARY, 
	   DBO.FX_TAX(SALARY), 
	   HIRE_DATE, JOB_ID, DEPARTMENT_ID
FROM EMPLOYEES
WHERE EMPLOYEE_ID = 100;

--

ALTER FUNCTION UDF_TEXT_TRUNCATE(@TEXT VARCHAR(50))
RETURNS VARCHAR(3)
AS
BEGIN
	RETURN UPPER(@TEXT)
END;

SELECT DBO.UDF_TEXT_TRUNCATE('nikhil');

SELECT EMPLOYEE_ID, LAST_NAME, SALARY, 
	   SALARY * 0.3 AS TAX, 
	   HIRE_DATE, JOB_ID, DEPARTMENT_ID,
	   DBO.UDF_TEXT_TRUNCATE(DATENAME(MM,HIRE_DATE)) AS HIRE_MONTH
FROM EMPLOYEES
WHERE EMPLOYEE_ID = 100;

ALTER FUNCTION FX_TAX (@DATA FLOAT)
RETURNS FLOAT
AS
BEGIN
	RETURN @DATA * 0.5
END;

DROP FUNCTION FX_TAX;

CREATE FUNCTION UDF_DEPT_NAME (@DID INT)
RETURNS VARCHAR(50)
AS
BEGIN
	DECLARE @ANS VARCHAR(50);
	SELECT @ANS = DEPARTMENT_NAME FROM DEPARTMENTS WHERE DEPARTMENT_ID = @DID;
	RETURN @ANS;
END;

--OR 
CREATE FUNCTION UDF_DEPT_NAME1 (@DID INT)
RETURNS VARCHAR(50)
AS
BEGIN
	RETURN (SELECT DEPARTMENT_NAME FROM DEPARTMENTS WHERE DEPARTMENT_ID = @DID);
END;

SELECT DBO.UDF_DEPT_NAME(50)
SELECT DBO.UDF_DEPT_NAME1(10)

-- TABLES VALUED FUNCTIONS -- RETURNS RESULT SET (TABLE)

CREATE FUNCTION UDF_EMP (@DID INT)
RETURNS TABLE
RETURN (SELECT EMPLOYEE_ID, LAST_NAME, SALARY, JOB_ID, HIRE_DATE, DEPARTMENT_ID
	    FROM EMPLOYEES
		WHERE DEPARTMENT_ID = @DID);

SELECT * FROM DBO.UDF_EMP(30);
SELECT * FROM UDF_EMP(30);	--TYPING DBO ISN'T MANDATORY FOR TABLE VALUED FUNCTIONS

SELECT E.EMPLOYEE_ID, D.DEPARTMENT_ID, E.LAST_NAME, E.JOB_ID, E.SALARY, D.DEPARTMENT_NAME
FROM DBO.UDF_EMP(30) E INNER JOIN DEPARTMENTS D
ON E.DEPARTMENT_ID = D.DEPARTMENT_ID;

-- STORED PROCEDURE RESULT CANNOT BE USED FURTHER; IT IS TO DISPLAY RESULT
-- WHILE FUNCTION RETURNED RESULT CAN BE USED FURTHER

ALTER FUNCTION UDF_DEPT_AGG ()
RETURNS TABLE
RETURN (
	    SELECT D.DEPARTMENT_NAME, SUM(SALARY) AS TOTAL_SALARY, ISNULL(AVG(SALARY),0) AS AVG_SALARY,
			   MIN(SALARY) AS MIN_SALARY, MAX(SALARY) AS MAX_SALARY
		FROM EMPLOYEES E INNER JOIN DEPARTMENTS D
		ON E.DEPARTMENT_ID = D.DEPARTMENT_ID
		GROUP BY D.DEPARTMENT_NAME
		);

SELECT * FROM UDF_DEPT_AGG()

CREATE FUNCTION UDF_HIGHPAY()
RETURNS TABLE
RETURN (
	   SELECT MAX(SALARY) AS MAX_SALARY
	   FROM EMPLOYEES
	   GROUP BY DEPARTMENT_ID);

SELECT * FROM(
SELECT DEPARTMENT_ID, EMPLOYEE_ID, LAST_NAME, SALARY, 
	   RANK() OVER (PARTITION BY DEPARTMENT_ID ORDER BY SALARY DESC) AS EMP_RANK
FROM EMPLOYEES) INFO
WHERE EMP_RANK = 1;

CREATE FUNCTION UDF_SAL_RANK()
RETURNS TABLE
RETURN (
	SELECT DEPARTMENT_ID, EMPLOYEE_ID, LAST_NAME, SALARY, 
	   RANK() OVER (PARTITION BY DEPARTMENT_ID ORDER BY SALARY DESC) AS EMP_RANK
FROM EMPLOYEES);

SELECT * FROM UDF_SAL_RANK() WHERE EMP_RANK = 1;

								-------- TRANSACTION IN SQL SERVER ---------

SELECT * FROM BANK;

DELETE FROM BANK 
WHERE CID = 60;

ROLLBACK; -- ERROR; BY DEFAULT, IT IS AUTO-COMMIT

BEGIN TRAN
	DELETE FROM BANK
	WHERE CID = 50;

ROLLBACK; -- SUCCESSFUL

BEGIN TRAN
	UPDATE BANK
	SET BALANCE = BALANCE * 2;

COMMIT;
ROLLBACK; --AFTER COMMIT, CAN'T ROLLBACK

BEGIN TRAN
	TRUNCATE TABLE BANK;

ROLLBACK;

-- DDL COMMANDS CAN ONLY GET ROLLED BACK IN SQL SERVER

DBCC USEROPTIONS;

-- 

-- TO CREATE PK NON CLUSTERED:
-- ALTER TABLE <TABLE_NAME> ADD CONSTRAINT <CONSTRAINT_NAME> PRIMARY KEY NONCLUSTERED (<COLUMN_NAME>)