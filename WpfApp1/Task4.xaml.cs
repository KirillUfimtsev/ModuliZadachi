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
    /// Логика взаимодействия для Task4.xaml
    /// </summary>
    public partial class Task4 : Window
    {
        public int[] arr = new int[30];
        public Task4()
        {
            InitializeComponent();
            Random rnd = new Random();
            for (int i = 0; i < 30; i++)
            {
                arr[i] = rnd.Next(0,10);
                tx1.Text = tx1.Text + " " + arr[i];
            }
                
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tx3.Clear();
            Array.Sort(arr);
            foreach(int i in arr)
            {
                tx3.Text = tx3.Text + " " + i;
            }
        }
    }
}
