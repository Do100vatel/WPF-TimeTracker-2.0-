
using System;

namespace WPF_TimeTracker_2._0_.Model
{
    public class TimerModel
    {
        public string Name  {get; set;}
        public TimeSpan Duration  {get; set;}
        public CategoryModel Category  {get; set;}
        public bool IsRunning  {get; set;}
        public DateTime StartTime  { get; set; }



        public void Start()
        {
            IsRunning = true;
            StartTime = DateTime.Now;
        }

        public void Stop()
        {
            if (IsRunning)
            {
                Duration += DateTime.Now - StartTime;
                IsRunning = false;
            }
        }

    }
}
