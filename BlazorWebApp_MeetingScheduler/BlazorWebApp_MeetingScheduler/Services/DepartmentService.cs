using System.Collections.Generic;
using BlazorWebApp_MeetingScheduler.Models;
using System .Threading.Tasks;


namespace BlazorWebAop_MeetingScheduler.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly List<Department> _departments = new List<Department> 
        {
            new Department { Id = 101, Name = "Human Resources", Manager = new Employee(), WeeklyMeeting = new Meeting() },
            new Department { Id = 102, Name = "IT", Manager = new Employee(), WeeklyMeeting = new Meeting() },
            new Department { Id = 103, Name = "Management", Manager = new Employee(), WeeklyMeeting = new Meeting() },
            new Department { Id = 104, Name = "Marketing", Manager = new Employee(), WeeklyMeeting = new Meeting() },
            new Department { Id = 105, Name = "Warehouse", Manager = new Employee(), WeeklyMeeting = new Meeting() }
        };


        public TaskList<Department>> GetDepartments()
        {   

            // return data from database for all departments
            return Task.FromResult(_departments);
        }



     }






}
