using EmpModels.Models;
using Microsoft.AspNetCore.JsonPatch;
namespace IVPEmpAPI.EmployeeRepo;

public interface IEmployee
{
    public Task<List<Employee>> GetAllEmployees();
    public Task<Employee> GetEmployeeById(int Id);
    public Task<int> AddEmployee(Employee emp);
    public Task<string> DeleteEmployee(int Id);
    public Task<string> UpdateEmployee(Employee emp, int Id);
    public Task<string> UpdateEmployeeSalary (int Id, JsonPatchDocument patch);
    public Task<string> UpdateDesignation(int Id, JsonPatchDocument patch);
}
