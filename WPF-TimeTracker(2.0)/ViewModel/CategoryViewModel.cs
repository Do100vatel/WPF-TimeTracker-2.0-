
using System.ComponentModel;
using WPF_TimeTracker_2._0_.Model;

namespace WPF_TimeTracker_2._0_.ViewModel
{
    public class CategoryViewModel : INotifyPropertyChanged
    {
        public CategoryModel Category { get; set; }
    
        public CategoryViewModel(CategoryModel category) 
        {
            Category = category;
        }

        public void AddSubcategory(string name)
        {
            Category.Subcategories.Add(new CategoryModel(name));
            OnPropertyChanged(nameof(Category));
        }

        public void RemoveSubcategory(CategoryModel subcategory)
        {
            Category.Subcategories.Remove(subcategory);
            OnPropertyChanged(nameof(Category));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
