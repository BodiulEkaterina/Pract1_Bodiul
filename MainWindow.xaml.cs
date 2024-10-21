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

namespace Pract1_Bodiul
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

        public void Button_result(object sender, RoutedEventArgs e)
        {
            int a, b, c;

            //ошибка целостности  данных
            if (TextBox_a.Text == "")
            {
                MessageBox.Show("Вы не ввели сторону 1");
                return;

            }
            if (String.IsNullOrEmpty(TextBox_b.Text))
            {
                MessageBox.Show("Вы не ввели сторону 2");
                return;
            }
            if (String.IsNullOrEmpty(TextBox_c.Text))
            {
                MessageBox.Show("Вы не ввели сторону 3");
                return;
            }

            if (TextBox_a.Text == "0")
            {
                MessageBox.Show("Не может быть равно 0");
                TextBox_a.Clear();
                return;

            }
            if (String.IsNullOrEmpty(TextBox_b.Text))
            {
                MessageBox.Show("Не может быть равно 0");
                TextBox_a.Clear();
                return;
            }
            if (String.IsNullOrEmpty(TextBox_c.Text))
            {
                MessageBox.Show("Не может быть равно 0");
                TextBox_a.Clear();
                return;
            }

            //ошибка корректность данных
            if (!Int32.TryParse(TextBox_a.Text, out a))
            {
                MessageBox.Show("Первая сторона некорректна");
                TextBox_a.Clear();
                return;
            }
            if (!Int32.TryParse(TextBox_b.Text, out b))
            {
                MessageBox.Show("Вторая сторона некорректна");
                TextBox_b.Clear();
                return;
            }
            if (!Int32.TryParse(TextBox_c.Text, out c))
            {
                MessageBox.Show("Третья сторона некорректна");
                TextBox_c.Clear();
                return;
            }

            a = Convert.ToInt32(TextBox_a.Text);
            b = Convert.ToInt32(TextBox_b.Text);
            c = Convert.ToInt32(TextBox_c.Text);

            if ((a + b <= c) || (a + c <= b) || (b + c <= a)) // не треугольник 
            {
                Window_not main = new Window_not();
                main.Show();
                this.Close();                
            }
            else
            
            if ((a == b) && (b == c)) // равносторонний треугольник
            {
                Window_ravn main = new Window_ravn();
                main.Show();
                this.Close();
            }
            else
            
            if (((a == b) && (b != c)) || ((a == c) && (b != c)) || ((b == c) && (a != c))) // равнобедренный треугольник
            {
                Window_ravnobed main = new Window_ravnobed();
                main.Show();
                this.Close();
            }
            else

            if ((a != b) && (b != c) && (a != c)) // разносторонний треугольник
            {
                Window_razn main = new Window_razn();
                main.Show();
                this.Close();
            }
        }

        private void Button_exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
