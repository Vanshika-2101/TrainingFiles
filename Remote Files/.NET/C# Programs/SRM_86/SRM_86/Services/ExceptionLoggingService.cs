using SRM_86.Models;

public class ExceptionLoggingService
{
    private readonly Srm86Context _context;

    public ExceptionLoggingService(Srm86Context context)
    {
        _context = context;
    }

    public void LogException(Exception exception, int? userId = null, string username = null)
    {
        var auditLog = new AuditLog
        {
            TableName = "Exception",
            StartTimestamp = DateTime.UtcNow,
            ActionType = "Error",
            UserId = 1,
            Username = "SA",
            OldValue = exception.Message,
            NewValue = exception.StackTrace,
            Comments = exception.ToString()
        };

        _context.AuditLogs.Add(auditLog);
        _context.SaveChanges();
    }
}
