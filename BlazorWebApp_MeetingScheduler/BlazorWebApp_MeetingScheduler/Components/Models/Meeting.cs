namespace BlazorWebApp_MeetingScheduler.Components.Models
{
    public class Meeting
    {
        public string MeetingId { get; }
        public int DepartmentId { get; }
        public string DepartmentName { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }

        private Department department;

        public Meeting(int departmentId, string departmentName, Department department) 
        {
            MeetingId = Guid.NewGuid().ToString();
            DepartmentId = departmentId;
            DepartmentName = departmentName;
            StartTime = StartTime;
            EndTime = EndTime;
            this.department = department;
        }
    }
}
