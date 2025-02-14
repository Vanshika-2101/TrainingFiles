-- AUDIT TABLE CREATION
CREATE TABLE AuditLog (
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    TableName VARCHAR(255) NOT NULL,
    StartTimestamp DATETIME NOT NULL,
    EndTimestamp DATETIME NULL,  
    UserId INT NULL,            
    Username VARCHAR(255) NULL, 
    ActionType VARCHAR(50) NOT NULL, 
    OldValue NVARCHAR(MAX) NULL,   
    NewValue NVARCHAR(MAX) NULL,   
    Comments NVARCHAR(MAX) NULL      
);


