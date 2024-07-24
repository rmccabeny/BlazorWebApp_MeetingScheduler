namespace BlazorWebApp_MeetingScheduler.Models
{
    // set fields for department class
    public class Department
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required List<Employee> Employees { get; set; }
        public required Employee Manager { get; set; }
        public required Meeting WeeklyMeeting { get; set; }

    }
}
