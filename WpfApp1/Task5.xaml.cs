using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Task5.xaml
    /// </summary>
    public partial class Task5 : Window
    {
        public Task5()
        {
            InitializeComponent();
            first.ItemsSource = null;
            second.ItemsSource = null;
            third.ItemsSource = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool m1 = int.TryParse(m.Text, out var cols);
            bool n1 = int.TryParse(n.Text, out var rows);
            if (!(m1 & n1))
            {
                MessageBox.Show("Неправильный ввод!");
                return;
            }
            var mainarr = ArrRandom(cols, rows);
            first.ItemsSource = ToDT(mainarr).DefaultView;
            second.ItemsSource = ToDT(sorted(mainarr)).DefaultView;
            third.ItemsSource = ToDT(reversed(mainarr)).DefaultView;
            max.Content = Arr1d(mainarr).Max();
            min.Content = Arr1d(mainarr).Min();
        }


        private DataTable ToDT(int[,] arr)
        {
            DataTable dt = new DataTable();

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                dt.Columns.Add();
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                var row = dt.NewRow();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    row[j] = arr[i, j];
                }
                dt.Rows.Add(row);
            }
            return dt;
        }
        private int[,] ArrRandom(int cols, int rows)
        {
            Random rnd = new Random();
            int[,] arr = new int[cols, rows];
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    arr[i,j] = rnd.Next(-10, 10);
                }
            }
            return arr;
        }

        private int[] Arr1d(int[,] arr2d)
        {
            int[] arr = new int[arr2d.Length];
            int z = 0,size = (int)Math.Sqrt(arr2d.Length);
            for (int i = 0; i < arr2d.GetLength(0); i++)
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    arr[z] = arr2d[i, j];
                    z++;
                }
            return arr;
        }

        private int[,] Arr2d(int[] arr1d,int cols,int rows)
        {
            int[,] arr = new int[cols, rows];
            int z = 0;
            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    arr[i, j] = arr1d[z++];
            return arr;
        }

        private int[,] sorted(int[,] arr2d)
        {
            int[] arr = Arr1d(arr2d);
            Array.Sort(arr);
            return Arr2d(arr,arr2d.GetLength(0),arr2d.GetLength(1));
        }
        private int[,] reversed(int[,] arr2d)
        {
            int[] arr= Arr1d(arr2d);
            Array.Sort(arr);
            Array.Reverse(arr);
            return Arr2d(arr, arr2d.GetLength(0), arr2d.GetLength(1));
        }

    }
}
