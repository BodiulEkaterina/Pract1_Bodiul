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

namespace Pract1_Bodiul
{
    /// <summary>
    /// Логика взаимодействия для Window_not.xaml
    /// </summary>
    public partial class Window_not : Window
    {
        public Window_not()
        {
            InitializeComponent();
        }

        private void Button_restart_not(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Button_exit_not(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
