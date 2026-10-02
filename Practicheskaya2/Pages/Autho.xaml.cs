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
using System.Windows.Shapes;

namespace Practicheskaya2.Pages
{
    public partial class Autho : Page
    {
        public Autho()
        {
            InitializeComponent();
        }

        private void btnEnterGuests_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Client(null));
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            // Заглушка — логику добавим позже
        }
    }
}
