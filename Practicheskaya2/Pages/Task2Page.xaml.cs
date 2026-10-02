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
    public partial class Task2Page : Page
    {
        private const string AlphabetLower = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
        private const string AlphabetUpper = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        public Task2Page()
        {
            InitializeComponent();
        }

        private void btnCalculate2_Click(object sender, RoutedEventArgs e)
        {
            string input = txtInput2.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Введите непустую строку!");
                return;
            }

            foreach (char c in input)
            {
                if (!IsValidChar(c))
                {
                    MessageBox.Show("Строка должна содержать русские буквы, пробелы и знаки препинания!");
                    return;
                }
            }

            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsLower(c) && AlphabetLower.Contains(c))
                {
                    int index = AlphabetLower.IndexOf(c);
                    int nextIndex = (index + 1) % AlphabetLower.Length;
                    result.Append(AlphabetLower[nextIndex]);
                }
                else if (char.IsUpper(c) && AlphabetUpper.Contains(c))
                {
                    int index = AlphabetUpper.IndexOf(c);
                    int nextIndex = (index + 1) % AlphabetUpper.Length;
                    result.Append(AlphabetUpper[nextIndex]);
                }
                else
                {
                    result.Append(c);
                }
            }

            txtResult2.Text = result.ToString();
        }

        private bool IsValidChar(char c)
        {
            if (char.IsLetter(c))
            {
                return (c >= 'А' && c <= 'я') || c == 'ё' || c == 'Ё';
            }
            return char.IsWhiteSpace(c) || char.IsPunctuation(c);
        }
    }
}
