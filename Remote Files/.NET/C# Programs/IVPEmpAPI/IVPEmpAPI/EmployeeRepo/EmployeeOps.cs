using Microsoft.EntityFrameworkCore;
using EmpDataAccess.Data;
using EmpModels.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace IVPEmpAPI.EmployeeRepo
{
    public class EmployeeOps : IEmployee
    {
        AppDbContext _context;
        public EmployeeOps(AppDbContext context) 
        {
            _context = context;     //Constructor injection; Class reference passed to another class
        }
        public async Task<List<Employee>> GetAllEmployees()
        {
            var employees = await _context.Employees.ToListAsync();
            return employees; 
        }

        public async Task<Employee> GetEmployeeById(int Id)
        {
            return await _context.Employees.FindAsync(Id);
        }

        public async Task<int> AddEmployee(Employee emp)
        {
            await _context.Employees.AddAsync(emp);
            await _context.SaveChangesAsync();
            return emp.EID;
        }

        public async Task<string> DeleteEmployee(int Id)
        {
            var data = await _context.Employees.FindAsync(Id);
            _context.Employees.Remove(data);
            await _context.SaveChangesAsync();
            return $"{Id} Data delete successfully.";
        }

        public async Task<string> UpdateEmployee(Employee emp, int Id)
        {
            var data = await _context.Employees.FindAsync(Id);
            if(data.EID == Id)
            {
                data.Name = emp.Name;
                data.Designation = emp.Designation;
                data.Salary = emp.Salary;
                await _context.SaveChangesAsync();
                return "Data updated successfully for " + Id;
            }
            return "No employee with Id = " + Id;
        }

        public async Task<string> UpdateEmployeeSalary(int Id, JsonPatchDocument patch)
        {
            var data = await _context.Employees.FindAsync(Id);
            if (data != null)
            {
                patch.ApplyTo(data);
                await _context.SaveChangesAsync();
                return "Salary Updated Successfully for " + Id;
            }
            return "No such employee exists";

        }
        public async Task<string> UpdateDesignation(int Id, JsonPatchDocument patch)
        {
            var data = await _context.Employees.FindAsync(Id);
            if (data != null)
            {
                patch.ApplyTo(data);
                await _context.SaveChangesAsync();
                return "Designation Updated Successfully for " + Id;
            }
            return "No such employee exists";
        }
    }
}
