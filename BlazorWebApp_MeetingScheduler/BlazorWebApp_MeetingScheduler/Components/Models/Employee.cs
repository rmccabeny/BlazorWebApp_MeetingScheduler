namespace BlazorWebApp_MeetingScheduler.Components.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public required string? FirstName { get; set; }
        public required string? LastName { get; set; }
        public required string? Email { get; set; }
        public required string? Phone { get; set; }
        public required string? DepartmentName { get; set; }
    }
}
