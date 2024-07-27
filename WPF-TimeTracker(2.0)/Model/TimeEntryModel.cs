
using System;

namespace WPF_TimeTracker_2._0_.Model
{
    public class TimeEntryModel 
    {
        public TimerModel Timer {get; set;}
        public DateTime StartTime {get; set;}
        public DateTime EndTime { get; set; }

        public TimeEntryModel(TimerModel timer, DateTime startTime, DateTime endTime)
        {
            Timer = timer;
            StartTime = startTime;
            EndTime = endTime;
        }

        public TimeSpan GetDuration()
        {
            return EndTime - StartTime;
        }
    }


}
