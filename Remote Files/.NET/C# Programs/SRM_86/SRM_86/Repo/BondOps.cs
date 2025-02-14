//using System.ComponentModel.DataAnnotations;
//using Microsoft.AspNetCore.JsonPatch;
//using Microsoft.EntityFrameworkCore;
//using SRM_86.Models;

//namespace SRM_86.Repo
//{
//    public class BondOps : IBonds
//    {
//        Srm86Context _context;
//        private readonly AuditLogService _auditLogService;


//        public BondOps(Srm86Context context, AuditLogService auditLogService)
//        {
//            _context = context;
//            _auditLogService = auditLogService;
//        }

//        public async Task<List<Bond>> GetAllBonds()
//        {
//            var bonds = await _context.Bonds.ToListAsync();
//            return bonds;
//        }

//        public async Task<Bond> GetBondById(int id)
//        {
//            var bond = await _context.Bonds.FindAsync(id);
//            return bond;
//        }

//        public async Task<Bond> GetBondByName(string name)
//        {
//            var bond = await _context.Bonds.FirstOrDefaultAsync(x => x.SecurityName == name);
//            return bond;
//        }

//        public async Task<int> AddNewBond(Bond bond)
//        {
//            await _context.Bonds.AddAsync(bond);
//            await _context.SaveChangesAsync();
//            _auditLogService.LogAudit("Bonds", "Create", 1, "system", null, bond.ToString(), "Created a new bond record.");
//            return bond.SecurityId;
//        }


//        public async Task<string> DeleteBondById(int id)
//        {
//            var bond = await _context.Bonds.FindAsync(id);
//            if (bond == null)
//            {
//                return null;
//            }
//            var oldValue = bond.ToString();
//            _context.Bonds.Remove(bond);
//            await _context.SaveChangesAsync();
//            _auditLogService.LogAudit("Bonds", "Delete", 1, "sa", oldValue, null, "Deleted a bond record.");
//            return "Deleted successfully.";
//        }

//        public async Task<string> UpdateBondById(int id, Bond bond)
//        {

//            _context.Entry(bond).State = EntityState.Modified;
//            var existingBond = _context.Bonds.Find(id);
//            var oldValue = existingBond.ToString();
//            existingBond = bond;

//            try
//            {
//                await _context.SaveChangesAsync();
//                _auditLogService.LogAudit("Bonds", "Update", 1, "sa", oldValue, bond.ToString(), "Updated a bond record.");
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!BondExists(id))
//                {
//                    return null;
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return "Updated Successfully";
//        }

//        private bool BondExists(int id)
//        {
//            return _context.Bonds.Any(e => e.SecurityId == id);
//        }




//        public async Task<string> UpdateSpecificBond(int id, JsonPatchDocument patchDoc)
//        {
//            // Get the bond from the database
//            var bond = await _context.Bonds.FindAsync(id);
//            if (bond == null)
//            {
//                return "Bond not found";
//            }

//            // Apply the patch document to the bond entity
//            patchDoc.ApplyTo(bond);
//            // Save changes to the database
//            await _context.SaveChangesAsync();

//            return "Bond updated successfully";
//        }



//    }
//}


using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SRM_86.Models;

namespace SRM_86.Repo
{
    public class BondOps : IBonds
    {
        Srm86Context _context;
        private readonly AuditLogService _auditLogService;
        private readonly ExceptionLoggingService _exceptionLoggingService;

        public BondOps(Srm86Context context, AuditLogService auditLogService, ExceptionLoggingService exceptionLoggingService)
        {
            _context = context;
            _auditLogService = auditLogService;
            _exceptionLoggingService = exceptionLoggingService;
        }

        public async Task<List<Bond>> GetAllBonds()
        {
            try
            {
                var bonds = await _context.Bonds.ToListAsync();
                return bonds;
            }
            catch (Exception ex)
            {
                // Log the exception
                _exceptionLoggingService.LogException(ex);
                throw new ApplicationException("An error occurred while retrieving the bonds.");
            }
        }

        public async Task<Bond> GetBondById(int id)
        {
            try
            {
                var bond = await _context.Bonds.FindAsync(id);
                if (bond == null)
                {
                    throw new KeyNotFoundException($"Bond with ID {id} not found.");
                }
                return bond;
            }
            catch (Exception ex)
            {
                // Log the exception
                _exceptionLoggingService.LogException(ex);
                throw new ApplicationException("An error occurred while retrieving the bond.");
            }
        }

        public async Task<Bond> GetBondByName(string name)
        {
            try
            {
                var bond = await _context.Bonds.FirstOrDefaultAsync(x => x.SecurityName == name);
                if (bond == null)
                {
                    throw new KeyNotFoundException($"Bond with name {name} not found.");
                }
                return bond;
            }
            catch (Exception ex)
            {
                // Log the exception
                _exceptionLoggingService.LogException(ex);
                throw new ApplicationException("An error occurred while retrieving the bond.");
            }
        }

        public async Task<int> AddNewBond(Bond bond)
        {
            try
            {
                await _context.Bonds.AddAsync(bond);
                await _context.SaveChangesAsync();
                var newVal = JsonConvert.SerializeObject(bond);
                _auditLogService.LogAudit("Bonds", "Create", 1, "system", null, newVal, "Created a new bond record.");
                return bond.SecurityId;
            }
            catch (Exception ex)
            {
                // Log the exception
                _exceptionLoggingService.LogException(ex);
                throw new ApplicationException("An error occurred while creating the bond.");
            }
        }

        public async Task<string> DeleteBondById(int id)
        {
            try
            {
                var bond = await _context.Bonds.FindAsync(id);
                if (bond == null)
                {
                    throw new KeyNotFoundException($"Bond with ID {id} not found.");
                }

                var oldValue = JsonConvert.SerializeObject(bond); 
                _context.Bonds.Remove(bond);
                await _context.SaveChangesAsync();
                _auditLogService.LogAudit("Bonds", "Delete", 1, "sa", oldValue, null, "Deleted a bond record.");
                return "Deleted successfully.";
            }
            catch (Exception ex)
            {
                // Log the exception
                _exceptionLoggingService.LogException(ex);
                throw new ApplicationException("An error occurred while deleting the bond.");
            }
        }

        public async Task<string> UpdateBondById(int id, Bond bond)
        {
            try
            {
                var existingBond = await _context.Bonds.FindAsync(id);
                if (existingBond == null)
                {
                    throw new KeyNotFoundException($"Bond with ID {id} not found.");
                }

                var oldValue = JsonConvert.SerializeObject(existingBond);
                _context.Entry(existingBond).CurrentValues.SetValues(bond);
                existingBond = bond;  // Update existing bond with new data
                var newValue = JsonConvert.SerializeObject(bond);

                await _context.SaveChangesAsync();
                _auditLogService.LogAudit("Bonds", "Update", 1, "sa", oldValue, newValue, "Updated a bond record.");
                return "Updated Successfully";
            }
            catch (DbUpdateConcurrencyException ex)
            {
                // Log the exception
                _exceptionLoggingService.LogException(ex);
                if (!BondExists(id))
                {
                    throw new KeyNotFoundException($"Bond with ID {id} not found.");
                }
                else
                {
                    throw new ApplicationException("A concurrency error occurred while updating the bond.");
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                _exceptionLoggingService.LogException(ex);
                throw new ApplicationException("An error occurred while updating the bond.");
            }
        }

        private bool BondExists(int id)
        {
            return _context.Bonds.Any(e => e.SecurityId == id);
        }

        public async Task<string> UpdateSpecificBond(int id, JsonPatchDocument patchDoc)
        {
            try
            {
                var bond = await _context.Bonds.FindAsync(id);
                if (bond == null)
                {
                    throw new KeyNotFoundException($"Bond with ID {id} not found.");
                }

                patchDoc.ApplyTo(bond);
                await _context.SaveChangesAsync();

                return "Bond updated successfully";
            }
            catch (Exception ex)
            {
                // Log the exception
                _exceptionLoggingService.LogException(ex);
                throw new ApplicationException("An error occurred while updating the bond.");
            }
        }
    }
}
