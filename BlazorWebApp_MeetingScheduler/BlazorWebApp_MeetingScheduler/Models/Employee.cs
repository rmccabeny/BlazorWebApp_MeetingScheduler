namespace BlazorWebApp_MeetingScheduler.Models
{
    // set fields for employee class
    public class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required Department Department { get; set; }
        public bool IsManager { get; set; }
    }
}
