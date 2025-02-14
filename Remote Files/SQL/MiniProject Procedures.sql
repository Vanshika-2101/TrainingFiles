USE IVP3686;

-- ADMIN PROCEDURES

CREATE PROC MiniProject.USP_ADMIN_FETCH
AS
BEGIN
	SELECT AdminID, AdminName, UserID, REPLICATE('*', LEN(Password)) AS Password, 
		   AdminContact, AdminEmail FROM MiniProject.Administrator;
END;

ALTER PROC MiniProject.USP_ADMIN_UPDATE @Id CHAR(5), @Name VARCHAR(50), @UId VARCHAR(50), @Pass VARCHAR(50), @Contact VARCHAR(50), @Mail VARCHAR(50)
AS
BEGIN
	INSERT INTO MiniProject.Administrator(AdminID, AdminName, UserID, Password, AdminContact, AdminEmail)
	VALUES(@Id, @Name, @UId, @Pass, @Contact, @Mail);
END;

ALTER PROC MiniProject.USP_ADMIN_DELETE @Id CHAR(5)
as
BEGIN
	DELETE FROM MiniProject.Administrator WHERE AdminID = @Id;
END

CREATE PROCEDURE MiniProject.USP_ADMIN_BY_ID @Id CHAR(5)
AS
BEGIN
	SELECT AdminID, AdminName, UserID, REPLICATE('*', LEN(Password)) AS Password, 
		   AdminContact, AdminEmail
	FROM MiniProject.Administrator WHERE AdminID ='MS001';
END

INSERT INTO MiniProject.Administrator VALUES('MS001', 'VANSHIKA', 'VANSHIKA21', 'VANSHIKA1', 'VANSHIKA123', 'VANSHIKA@21');

EXEC MiniProject.USP_ADMIN_DELETE @Id = 'MS001';


-- STUDENT PROCEDURES

CREATE PROCEDURE MiniProject.USP_STUD_FETCH
AS
BEGIN
	SELECT SID, FirstName, LastName, Email, StreamID, Grade, Marks, AdmissionDate
	FROM MiniProject.Student;
END;

CREATE PROC MiniProject_USP_STUD_ADD @Id INT
AS
BEGIN
	
END;