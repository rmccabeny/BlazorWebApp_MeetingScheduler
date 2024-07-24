using BlazorWebApp_MeetingScheduler.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorWebApp_MeetingScheduler.Data;

namespace BlazorWebApp_MeetingScheduler.Services
{
    // creating the employee service
    public class EmployeeService
    {
        // creates the interface for the employee service
        public interface IEmployeeService
        {
            Task<List<Employee>> GetAllEmployeesByIdAsync();
            Task<Employee> GetEmployeeByIdAsync(int id);
            Task CreateEmployeeAsync(Employee employee);
            Task UpdateEmployeeAsync(Employee employee);
            Task DeleteEmployeeAsync(int id);
        }
    }
}
