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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button but_exit = new Button();
        Button but_history = new Button();
        Button but_role = new Button();
        Button but_zayav = new Button();
        public static string role = "";
        public MainWindow()
        {
            InitializeComponent();
            but_exit.Content = "Выход";
            but_exit.VerticalAlignment = VerticalAlignment.Center;
            but_exit.HorizontalAlignment = HorizontalAlignment.Center;
            but_exit.Click += new RoutedEventHandler(go_page_exit);
            stack_panel.Children.Add(but_exit);

            but_history.Content = "История входа";
            but_history.VerticalAlignment = VerticalAlignment.Center;
            but_history.HorizontalAlignment = HorizontalAlignment.Center;
            but_history.Click += new RoutedEventHandler(go_page_history);

            but_role.Content = "Специальности";
            but_role.VerticalAlignment = VerticalAlignment.Center;
            but_role.HorizontalAlignment = HorizontalAlignment.Center;
            but_role.Click += new RoutedEventHandler(go_page_spec);

            but_zayav.Content = "Заявления";
            but_zayav.VerticalAlignment = VerticalAlignment.Center;
            but_zayav.HorizontalAlignment = HorizontalAlignment.Center;

            but_zayav.Visibility = Visibility.Collapsed;
            but_history.Visibility = Visibility.Collapsed;
            but_role.Visibility = Visibility.Collapsed;

            stack_panel.Children.Add(but_history);
            stack_panel.Children.Add(but_role);
            stack_panel.Children.Add(but_zayav);

            Frame_Navigate.Navigate(new page_login());
        }
        private void go_page_exit(object seder, EventArgs e)
        {
            page_exit page1 = new page_exit();
            page1.Show();
        }
        private void go_page_spec(object seder, EventArgs e)
        {
            Frame_Navigate.Navigate(new page_spec());
        }
        private void go_page_history(object seder, EventArgs e)
        {
            Frame_Navigate.Navigate(new page_history());
        }

        private void Frame_Navigate_Navigated(object sender, NavigationEventArgs e)
        {
            if (role == "volonter")
            {
                but_role.Visibility = Visibility.Visible;
            }
            if (role == "sotrudnik")
            {
                but_zayav.Visibility = Visibility.Visible;
            }
            if (role == "zav")
            {
                but_history.Visibility = Visibility.Visible;
            }

        }
    }
}
