namespace BlazorWebApp_MeetingScheduler.Models
{
    // set fields for meeting class
    public class Meeting
    {
        public int Id { get; set; }
        public required Department Department { get; set; }
        public  DayOfWeek DayOfWeek { get; set; }
        public TimeSpan Time { get; set; }
    }
}
