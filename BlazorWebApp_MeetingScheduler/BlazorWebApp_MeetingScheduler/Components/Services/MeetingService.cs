using BlazorWebApp_MeetingScheduler.Components.Models;
using System.Collections.Generic;

namespace BlazorWebApp_MeetingScheduler.Services
{
    public class MeetingService
    {
        private List<Meeting> meetings;

        public MeetingService()
        {
            meetings = new List<Meeting>();
        }


        public void ScheduleMeeting(string name, Department department, DateTime startTime, DateTime endTime)
        {
            //access the department id and name
            int departmentId = department.Id;
            string departmentName = department.Name;
            
            //create a new meeting object
            Meeting meeting = new Meeting(departmentId, departmentName, startTime, endTime);

            //add the meeting to the meetings collection
            meetings.Add(meeting);
        }

        public List<Meeting> GetMeetings()
        {
            return meetings;
        }
    }
}