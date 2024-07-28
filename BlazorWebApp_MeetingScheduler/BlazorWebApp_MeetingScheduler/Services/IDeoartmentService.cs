using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorWebApp_MeetingScheduler.Models;

namespace BlazorWebApp_MeetingScheduler.Services
{
    public interface IDepartmentService 
    {
        Task<List<Department>> GetDepartments();
        Task<Department> GetDepartmentByIdAsync(int Id);
        Task CreateDepartmentAsync(Department department);
        Task UpdateDepartmentAsync(Department department);
        Task DeleteDepartmentAsync(int Id);
    }
}
