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
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void btnCalculate1_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtInput1.Text, out int number))
            {
                MessageBox.Show("Введите корректное целое число!");
                return;
            }

            int absNumber = Math.Abs(number);
            if (absNumber < 1000 || absNumber > 9999)
            {
                MessageBox.Show("Число должно быть четырёхзначным (от 1000 до 9999)!");
                return;
            }

            int sum = 0;
            int product = 1;
            int temp = absNumber;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += digit;
                product *= digit;
                temp /= 10;
            }

            txtResult1.Text = $"Сумма цифр: {sum}\nПроизведение цифр: {product}";
        }
    }
}