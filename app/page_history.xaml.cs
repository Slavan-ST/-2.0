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

namespace app
{
    /// <summary>
    /// Логика взаимодействия для page_history.xaml
    /// </summary>
    public partial class page_history : Page
    {
        public page_history()
        {
            InitializeComponent();
            list_view.ItemsSource = ConnectDB.connnectDB.history_login.ToList();
        }
    }
}
