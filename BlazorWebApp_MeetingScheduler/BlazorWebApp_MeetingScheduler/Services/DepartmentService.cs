using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorWebApp_MeetingScheduler.Models;
using BlazorWebApp_MeetingScheduler.Data;

namespace BlazorWebApp_MeetingScheduler.Services
{
    // creating the department service
    public class DepartmentService
    {
        // creating the interface for the department service
        public interface IDepartmentService
        {
            Task <List<Department>> GetDepartments();
            Task<Department> GetDepartmentByIdAsync(int id);
            Task CreateDepartmentAsync(Department department);
            Task UpdateDepartmentAsync(Department department);
            Task DeleteDepartmentAsync(int id);
        }
    }
}
