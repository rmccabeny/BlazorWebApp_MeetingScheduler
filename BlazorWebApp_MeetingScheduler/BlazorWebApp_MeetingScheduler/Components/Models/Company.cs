using BlazorWebApp_MeetingScheduler.Components.Models;
using System.Collections.Generic;

namespace BlazorWebApp_MeetingScheduler.Components.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public required string CompanyName { get; set; }
        public required string CompanyEmail { get; set; }
        public string? CompanyPhone { get; set; }
        //stores a list of departments to be used by the company
        //Initializes a new instance of a list of departments
        List<Department> Departments { get; set; } = new List<Department>();
    }
}
