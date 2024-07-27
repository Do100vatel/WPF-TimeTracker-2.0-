using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_TimeTracker_2._0_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
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
