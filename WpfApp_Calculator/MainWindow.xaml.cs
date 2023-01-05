using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace WpfApp_Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string s1 = First_Number.Text;
                string s2 = Second_Number.Text;
                int n1 = Convert.ToInt32(s1, 2);
                int n2 = Convert.ToInt32(s2, 2);
                int ans = n1 + n2;
                Answer.Text = Convert.ToString(ans, 2);
            }
            catch
            {
                MessageBox.Show("Некорректный ввод! Попробуйте еще раз");
            }

        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string s1 = First_Number.Text;
                string s2 = Second_Number.Text;
                int n1 = Convert.ToInt32(s1, 2);
                int n2 = Convert.ToInt32(s2, 2);
                int ans = n1 - n2;
                if (ans < 0)
                    Answer.Text = "-" + Convert.ToString(-ans, 2);
                else
                    Answer.Text = Convert.ToString(ans, 2);
            }
            catch
            {
                MessageBox.Show("Некорректный ввод! Попробуйте еще раз");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string s1 = First_Number.Text;
                string s2 = Second_Number.Text;
                int n1 = Convert.ToInt32(s1, 2);
                int n2 = Convert.ToInt32(s2, 2);
                int ans = n1 * n2;
                Answer.Text = Convert.ToString(ans, 2);
            }
            catch
            {
                MessageBox.Show("Некорректный ввод! Попробуйте еще раз");
            }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string s1 = First_Number.Text;
                string s2 = Second_Number.Text;
                int n1 = Convert.ToInt32(s1, 2);
                int n2 = Convert.ToInt32(s2, 2);
                int ans = n1 / n2;
                Answer.Text = Convert.ToString(ans, 2);
            }
            catch
            {
                MessageBox.Show("Некорректный ввод! Попробуйте еще раз");
            }
        }

        private void Modul_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string s1 = First_Number.Text;
                string s2 = Second_Number.Text;
                int n1 = Convert.ToInt32(s1, 2);
                int n2 = Convert.ToInt32(s2, 2);
                int ans = n1 % n2;
                Answer.Text = Convert.ToString(ans, 2);
            }
            catch
            {
                MessageBox.Show("Некорректный ввод! Попробуйте еще раз");
            }
        }
    }
}
