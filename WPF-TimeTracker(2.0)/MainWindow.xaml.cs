using System.Windows;

namespace WPF_TimeTracker_2._0_
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AddTimer_Click(object sender, RoutedEventArgs e)
        {
            // Логика добавления таймера
        }

        private void ManageTimers_Click(object sender, RoutedEventArgs e)
        {
            // Логика управления таймерами
        }

        private void AddCategory_Click(object sender, RoutedEventArgs e)
        {
            // Логика добавления категории
        }

        private void ManageCategories_Click(object sender, RoutedEventArgs e)
        {
            // Логика управления категориями
        }
    }
}
