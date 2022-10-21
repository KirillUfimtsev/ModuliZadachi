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
    /// Логика взаимодействия для Task2.xaml
    /// </summary>
    public partial class Task2 : Window
    {
        public Task2()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list.Clear();
            _out.Clear();
            foreach (string item in txt.Text.Split(' '))
            {
                if (item!= "") list.Add(item.Trim());
            }

            list.Reverse();

            foreach(string str in list)
            {
                _out.Text = _out.Text+ " " + str;
            }
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
