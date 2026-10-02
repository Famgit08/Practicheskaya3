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
    public partial class Task4Page : Page
    {
        private int[] _array;

        public Task4Page()
        {
            InitializeComponent();
        }

        private void btnGenerate4_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtSize4.Text, out int n) || n < 2 || n > 100)
            {
                MessageBox.Show("Введите корректный размер массива (2–100)!");
                return;
            }

            Random rnd = new Random();
            _array = new int[n];
            for (int i = 0; i < n; i++)
                _array[i] = rnd.Next(-50, 51);

            txtArray4.Text = "Исходный массив: " + string.Join(", ", _array);
            txtResult4.Text = "";
        }

        private void btnCalculate4_Click(object sender, RoutedEventArgs e)
        {
            if (_array == null || _array.Length == 0)
            {
                MessageBox.Show("Сначала сгенерируйте массив!");
                return;
            }

            int minIndex = Array.IndexOf(_array, _array.Min());
            int maxIndex = Array.IndexOf(_array, _array.Max());

            int left = Math.Min(minIndex, maxIndex);
            int right = Math.Max(minIndex, maxIndex);

            Array.Reverse(_array, left + 1, right - left - 1);

            txtResult4.Text = "Массив после перестановки: " + string.Join(", ", _array);
        }
    }
}