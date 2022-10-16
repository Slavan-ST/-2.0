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

namespace app
{
    /// <summary>
    /// Логика взаимодействия для page_exit.xaml
    /// </summary>
    public partial class page_exit : Window
    {
        public page_exit()
        {
            InitializeComponent();
        }

        private void click_but_exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void click_but_exit_no(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
