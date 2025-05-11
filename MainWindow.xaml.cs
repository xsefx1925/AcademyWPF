using System;
using System.Windows;
using System.Windows.Controls;

namespace AcademyWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModels.MainViewModel();
        }

        // Обработчик события для переключения вкладок
        private void MainTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Логика загрузки данных для выбранной вкладки
            if (MainTabControl.SelectedItem is TabItem selectedTab)
            {
                string header = selectedTab.Header.ToString();
                switch (header)
                {
                    case "Students":
                        // Логика для вкладки Students
                        break;
                    case "Groups":
                        // Логика для вкладки Groups
                        break;
                    case "Directions":
                        // Логика для вкладки Directions
                        break;
                    case "Disciplines":
                        // Логика для вкладки Disciplines
                        break;
                    case "Teachers":
                        // Логика для вкладки Teachers
                        break;
                }
            }
        }

        // Обработчик события для изменения выбора в ComboBox
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox comboBox && comboBox.SelectedItem != null)
            {
                string selectedValue = comboBox.SelectedItem.ToString();
                // Логика фильтрации данных на основе выбранного значения
                Console.WriteLine($"Выбрано значение: {selectedValue}");
            }
        }
    }
}