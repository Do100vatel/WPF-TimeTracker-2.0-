
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Threading.Tasks;
using WPF_TimeTracker_2._0_.ViewModel;

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

        private readonly ApiService _apiService;

        public MainViewModel()
        {
            Timers = new ObservableCollection<TimerViewModel>();
            Categories = new ObservableCollection<CategoryViewModel>();

            _apiService = new ApiService();
            LoadCategories();
        }

        private async void LoadCategories()
        {
            var categories = await _apiService.GetCategoriesAsync();
            if (categories != null)
            {
                Categories = new ObservableCollection<CategoryViewModel>(
                    categories.Select(c => new CategoryViewModel(c))
                );
            }
        }

        public async Task AddCategory(CategoryModel category)
        {
            await _apiService.AddCategoryAsync(category);
            LoadCategories();
        }

        public async Task DeleteCategory(string categoryId)
        {
            await _apiService.DeleteCategoryAsync(categoryId);
            LoadCategories();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
