using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorWebApp_MeetingScheduler.Models;
using BlazorWebApp_MeetingScheduler.Data;

namespace BlazorWebApp_MeetingScheduler.Services
{
    // creates meeting service for application
    public class MeetingService
    {
        // creates interface for meeting service
        public interface IMeetingService
        {
            Task<List<Meeting>> GetAllMeetingsByIdAsync();
            Task<Meeting> GetMeetingByIdAsync(int id);
            Task<Meeting> AddMeeting(Meeting meeting);
            Task<Meeting> UpdateMeeting(Meeting meeting);
            Task<Meeting> DeleteMeeting(int id);
        }
    }
}
