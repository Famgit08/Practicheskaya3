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

namespace Practicheskaya2.Pages
{
    public partial class Task3Page : Page
    {
        private int[] _array;

        public Task3Page()
        {
            InitializeComponent();
        }

        private void btnGenerate3_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtSize3.Text, out int n) || n <= 0 || n > 100)
            {
                MessageBox.Show("Введите корректный размер массива (1–100)!");
                return;
            }

            Random rnd = new Random();
            _array = new int[n];
            for (int i = 0; i < n; i++)
                _array[i] = rnd.Next(-50, 51);

            txtArray3.Text = "Массив: " + string.Join(", ", _array);
            txtResult3.Text = "";
        }

        private void btnCalculate3_Click(object sender, RoutedEventArgs e)
        {
            if (_array == null || _array.Length == 0)
            {
                MessageBox.Show("Сначала сгенерируйте массив!");
                return;
            }

            var even = _array.Where(x => x % 2 == 0);
            var odd = _array.Where(x => x % 2 != 0);

            txtResult3.Text = "Чётные: " + string.Join(", ", even) + "\n" +
                              "Нечётные: " + string.Join(", ", odd);
        }
    }
}
