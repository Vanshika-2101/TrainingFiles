using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SRM_86.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SRM_86.Repo
{
    public class EquitiesOps : IEquities
    {
        private readonly Srm86Context _context;
        private readonly AuditLogService _auditLogService;
        private readonly ExceptionLoggingService _exceptionLoggingService;

        public EquitiesOps(Srm86Context context, AuditLogService auditLogService, ExceptionLoggingService exceptionLoggingService)
        {
            _context = context;
            _auditLogService = auditLogService;
            _exceptionLoggingService = exceptionLoggingService;
        }

        public async Task<List<Equity>> GetAllEquities()
        {
            try
            {
                var equities = await _context.Equities.ToListAsync();
                return equities;
            }
            catch (Exception ex)
            {
                _exceptionLoggingService.LogException(ex);
                throw new Exception("An error occurred while fetching the equities.", ex);
            }
        }

        public async Task<Equity> GetEquityById(int id)
        {
            try
            {
                var equity = await _context.Equities.FindAsync(id);
                if (equity == null)
                {
                    throw new Exception("Equity not found.");
                }
                return equity;
            }
            catch (Exception ex)
            {
                _exceptionLoggingService.LogException(ex);
                throw new Exception($"An error occurred while fetching the equity with ID {id}.", ex);
            }
        }

        public async Task<Equity> GetEquityByName(string name)
        {
            try
            {
                var equity = await _context.Equities.FirstOrDefaultAsync(x => x.SecurityName == name);
                if (equity == null)
                {
                    throw new Exception($"Equity with name {name} not found.");
                }
                return equity;
            }
            catch (Exception ex)
            {
                _exceptionLoggingService.LogException(ex);
                throw new Exception($"An error occurred while fetching the equity with name {name}.", ex);
            }
        }

        public async Task<int> AddNewEquity(Equity equity)
        {
            try
            {
                await _context.Equities.AddAsync(equity);
                await _context.SaveChangesAsync();
                var newVal = JsonConvert.SerializeObject(equity);
                _auditLogService.LogAudit("Equities", "Create", 1, "system", null, newVal, "Created a new equity record.");
                return equity.SecurityId;
            }
            catch (Exception ex)
            {
                _exceptionLoggingService.LogException(ex);
                throw new Exception("An error occurred while adding the new equity.", ex);
            }
        }

        public async Task<string> DeleteEquityById(int id)
        {
            try
            {
                var equity = await _context.Equities.FindAsync(id);
                if (equity == null)
                {
                    throw new Exception($"Equity with ID {id} not found.");
                }

                var oldValue = JsonConvert.SerializeObject(equity); ;
                _context.Equities.Remove(equity);
                await _context.SaveChangesAsync();
                _auditLogService.LogAudit("Equities", "Delete", 1, "sa", oldValue, null, "Deleted an equity record.");

                return "Deleted successfully.";
            }
            catch (Exception ex)
            {
                _exceptionLoggingService.LogException(ex);
                throw new Exception($"An error occurred while deleting the equity with ID {id}.", ex);
            }
        }

        public async Task<string> UpdateEquityById(int id, Equity equity)
        {
            try
            {
                var existingEquity = await _context.Equities.FindAsync(id);
                if (existingEquity == null)
                {
                    throw new Exception($"Equity with ID {id} not found.");
                }

                var oldValue = JsonConvert.SerializeObject(existingEquity);
                _context.Entry(existingEquity).CurrentValues.SetValues(equity);

                var newVal = JsonConvert.SerializeObject(equity);

                await _context.SaveChangesAsync();
                _auditLogService.LogAudit("Equities", "Update", 1, "sa", oldValue, newVal, "Updated an equity record.");

                return "Updated Successfully";
            }
            catch (DbUpdateConcurrencyException ex)
            {
                _exceptionLoggingService.LogException(ex);
                if (!EquityExists(id))
                {
                    throw new Exception($"Equity with ID {id} not found.");
                }
                else
                {
                    throw new Exception($"A concurrency error occurred while updating the equity with ID {id}.", ex);
                }
            }
            catch (Exception ex)
            {
                _exceptionLoggingService.LogException(ex);
                throw new Exception($"An error occurred while updating the equity with ID {id}.", ex);
            }
        }

        private bool EquityExists(int id)
        {
            return _context.Equities.Any(e => e.SecurityId == id);
        }

        public async Task<string> UpdateSpecificEquity(int id, JsonPatchDocument patchDoc)
        {
            try
            {
                var equity = await _context.Equities.FindAsync(id);
                if (equity == null)
                {
                    throw new Exception($"Equity with ID {id} not found.");
                }

                patchDoc.ApplyTo(equity);
                await _context.SaveChangesAsync();

                return "Equity updated successfully";
            }
            catch (Exception ex)
            {
                _exceptionLoggingService.LogException(ex);
                throw new Exception($"An error occurred while applying the patch to the equity with ID {id}.", ex);
            }
        }
    }
}

