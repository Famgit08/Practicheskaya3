using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Practicheskaya2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrmMain.Navigate(new Pages.Autho());
            WrapPanelTasks.Visibility = Visibility.Collapsed;  // скрываем меню
            btnBack.Visibility = Visibility.Hidden;
        }

        private void btnTask1_Click(object sender, RoutedEventArgs e)
        {
            OpenTask(new Pages.Task1Page());
        }

        private void btnTask2_Click(object sender, RoutedEventArgs e)
        {
            OpenTask(new Pages.Task2Page());
        }

        private void btnTask3_Click(object sender, RoutedEventArgs e)
        {
            OpenTask(new Pages.Task3Page());
        }

        private void btnTask4_Click(object sender, RoutedEventArgs e)
        {
            OpenTask(new Pages.Task4Page());
        }

        private void btnTask5_Click(object sender, RoutedEventArgs e)
        {
            OpenTask(new Pages.Task5Page());
        }

        /// <summary>
        /// Открывает страницу задачи и переключает видимость элементов.
        /// </summary>
        private void OpenTask(Page page)
        {
            FrmMain.Navigate(page);
            WrapPanelTasks.Visibility = Visibility.Collapsed;
            btnBack.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Возвращает в главное меню (к кнопкам задач).
        /// </summary>
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Content = null;                          // убираем страницу из Frame
            WrapPanelTasks.Visibility = Visibility.Visible;  // показываем меню
            btnBack.Visibility = Visibility.Hidden;          // скрываем "Назад"
        }
    }
}