
using System.Collections.Generic;
using System.Windows.Documents;

namespace WPF_TimeTracker_2._0_.Model
{
    public class CategoryModel 
    {
        public string Name { get; set; }
        public List<CategoryModel> Subcategories { get; set; }

        public CategoryModel(string name)
        { 
            Name = name;
            Subcategories = new List<CategoryModel>();
        }
    }

}
