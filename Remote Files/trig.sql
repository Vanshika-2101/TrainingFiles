USE SRM_86;

CREATE TRIGGER TRG_InsertAuditOnEquities 
ON dbo.Equities
AFTER INSERT
AS
BEGIN
	INSERT INTO dbo.AuditLog ([TableName],[StartTimestamp],[EndTimestamp],[UserId] ,[Username],
			[ActionType],[OldValue],[NewValue],[Comments])
		SELECT 'Equities', GETDATE(), GETDATE(), SUSER_ID(), SUSER_SNAME(), 'Insert', NULL, 
			CONCAT('Inserted: ', eq.SecurityID), 'Successfully inserted equity'
		FROM INSERTED eq;
END;

drop trigger TRG_InsertAuditOnEquities ;
