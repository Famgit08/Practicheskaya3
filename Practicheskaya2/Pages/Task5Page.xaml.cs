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
    public partial class Task5Page : Page
    {
        private int[,] _matrix;
        private int _rows, _cols;

        public Task5Page()
        {
            InitializeComponent();
        }

        private void btnGenerate5_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtRows5.Text, out _rows) || _rows <= 0 || _rows > 20 ||
                !int.TryParse(txtCols5.Text, out _cols) || _cols <= 0 || _cols > 20)
            {
                MessageBox.Show("Введите корректные размеры (1–20)!");
                return;
            }

            Random rnd = new Random();
            _matrix = new int[_rows, _cols];
            for (int i = 0; i < _rows; i++)
                for (int j = 0; j < _cols; j++)
                    _matrix[i, j] = rnd.Next(-10, 11);

            txtOriginal5.Text = "Исходный массив:\n" + MatrixToString(_matrix);
            txtAsc5.Text = "По возрастанию:";
            txtDesc5.Text = "По убыванию:";
            txtMinMax5.Text = "Max и Min:";
        }

        private void btnCalculate5_Click(object sender, RoutedEventArgs e)
        {
            if (_matrix == null)
            {
                MessageBox.Show("Сначала сгенерируйте массив!");
                return;
            }

            int total = _rows * _cols;
            int[] flat = new int[total];
            int k = 0;
            for (int i = 0; i < _rows; i++)
                for (int j = 0; j < _cols; j++)
                    flat[k++] = _matrix[i, j];

            int[] asc = (int[])flat.Clone();
            Array.Sort(asc);

            int[] desc = (int[])flat.Clone();
            Array.Sort(desc);
            Array.Reverse(desc);

            int max = flat.Max();
            int min = flat.Min();

            int[,] ascMatrix = ToMatrix(asc, _rows, _cols);
            int[,] descMatrix = ToMatrix(desc, _rows, _cols);

            txtAsc5.Text = "По возрастанию:\n" + MatrixToString(ascMatrix);
            txtDesc5.Text = "По убыванию:\n" + MatrixToString(descMatrix);
            txtMinMax5.Text = $"Max = {max}, Min = {min}";
        }

        private int[,] ToMatrix(int[] flat, int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            int k = 0;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = flat[k++];
            return matrix;
        }

        private string MatrixToString(int[,] matrix)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    sb.Append(matrix[i, j].ToString().PadLeft(4));
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}