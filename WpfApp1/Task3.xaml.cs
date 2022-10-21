using System;
using System.Collections;
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
    public partial class Task3 : Window
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            output.Clear();
            string str = input.Text;
            List<string> list = str.Trim().Split(' ').ToList();
            List<int> numbers = new List<int>();
            try
            {
                foreach (string str2 in list)
                {
                    numbers.Add(int.Parse(str2));
                }
            }
            catch
            {
                MessageBox.Show("Введите последовательность целых чисел!");
                return;
            }

            int index = 1, max = 0;
            int startInd = 0, endInd = 0;  
            List<int> biggest = new List<int>();
            while (index < numbers.Count)
            {
                startInd = index - 1;
                endInd = index - 1;
                for (int i = index; i < numbers.Count; i++)
                {
                    if (numbers[i] % numbers[i - 1] == 0)
                        endInd++;
                    else { break; }
                }
                endInd++;
                if (max <= endInd-startInd)
                {
                    max = endInd - startInd;
                    biggest.Clear();
                    for (int j = startInd; j < endInd; j++)
                    { 
                        biggest.Add(numbers[j]);
                    }
                }
                index++; 

            }
            foreach (int i in biggest)
            {
                output.Text = output.Text + i.ToString() + " ";
            }

        }        

    }
}
