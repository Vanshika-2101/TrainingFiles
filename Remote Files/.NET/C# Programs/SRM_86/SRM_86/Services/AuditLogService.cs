using System;
using SRM_86.Models;
using Microsoft.EntityFrameworkCore;

public class AuditLogService
{
    private readonly Srm86Context _context;

    public AuditLogService(Srm86Context context)
    {
        _context = context;
    }

    public void LogAudit(string tableName, string actionType, int? userId, string username, string? oldValue, string? newValue, string? comments)
    {
        var auditLog = new AuditLog
        {
            TableName = tableName,
            StartTimestamp = DateTime.UtcNow,
            EndTimestamp = DateTime.UtcNow,
            ActionType = actionType,
            UserId = userId,
            Username = username,
            OldValue = oldValue,
            NewValue = newValue,
            Comments = comments
        };

        _context.AuditLogs.Add(auditLog);
        _context.SaveChanges();
    }
}
