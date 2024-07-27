
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace WPF_TimeTracker_2._0_.Model
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<TimerViewModel> _timers;
        public ObservableCollection<TimerViewModel> Timers
        {
            get => _timers;
            set
            {
                _timers = value;
                OnPropertyChanged(nameof(Timers));
            }
        }


        private ObservableCollection<CategoryViewModel> _categories;
        public ObservableCollection<CategoryViewModel> Categories
        {
            get => _categories;
            set
            {
                _categories = value;    
                OnPropertyChanged(nameof(Categories));
            }
        }

        public MainViewModel()
        {
            Timers = new ObservableCollection<TimerViewModel>();
            Categories = new ObservableCollection<CategoryViewModel>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
