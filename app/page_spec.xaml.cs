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
    /// Логика взаимодействия для page_spec.xaml
    /// </summary>
    public partial class page_spec : Page
    {
        public page_spec()
        {
            InitializeComponent();
            list_view.ItemsSource = ConnectDB.connnectDB.Specs.ToList();
        }
    }
}
