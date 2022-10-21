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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Task1.xaml
    /// </summary>
    public partial class Task1 : Window
    {
        public Task1()
        {
            InitializeComponent();
        }

        public int factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return 2 * result;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            bool nat = int.TryParse(tx.Text, out int result);
            if (nat==false || result < 0)
            {
                label1.Content = "Введите натуральное число";
                return;
            }

            if (result > 100)
            {
                label1.Content = "Введите число не больше 100!";
                return;
            }
                   
            label1.Content = "Результат = " + factorial(Convert.ToInt32(tx.Text));
            
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
