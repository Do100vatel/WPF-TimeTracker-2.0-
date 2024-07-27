
using System.ComponentModel;
using WPF_TimeTracker_2._0_.Model;

namespace WPF_TimeTracker_2._0_.ViewModel
{
    public class TimerViewModel : INotifyPropertyChanged
    {
        public TimerModel Timer { get; set; }

        public TimerViewModel(TimerModel timer)
        {
            Timer = timer;
        }

        public void StartTimer()
        {
            Timer.Start();
            OnPropertyChanged(nameof(Timer));
        }

        public void StopTimer()
        {
            Timer.Stop();
            OnPropertyChanged(nameof(Timer));
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
