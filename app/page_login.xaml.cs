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
    /// Логика взаимодействия для page_login.xaml
    /// </summary>
    public partial class page_login : Page
    {
        public page_login()
        {
            InitializeComponent();
        }

        private void click_btn_login(object sender, RoutedEventArgs e)
        {
            string type = "Успешно";
            if (tb_login.Text == "1")
            {
                tb_login.Text = "student_sched";
                tb_password.Text = "4929";
            }
            if (tb_login.Text == "2")
            {
                tb_login.Text = "chief_kvl";
                tb_password.Text = "1735";
            }
            if (tb_login.Text == "3")
            {
                tb_login.Text = "sotrudnik_gmt";
                tb_password.Text = "9683";
            }


            var flag = ConnectDB.connnectDB.Sotrudniks.FirstOrDefault(p => p.login == tb_login.Text && p.password == tb_password.Text);
            if (flag != null)
            {
                if (flag.dolgh == "Волонтер")
                {
                    MainWindow.role = "volonter";
                }
                if (flag.dolgh == "Заведующая ПК")
                {
                    MainWindow.role = "zav";
                }
                if (flag.dolgh == "Сотрудник по работе с абируентами")
                {
                    MainWindow.role = "sotrudnik";
                }

                NavigationService.Navigate(new page_main());                
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль!");
                type = "Неуспешно";
            }
            history_login history_ob = new history_login()
            {
                last_login = DateTime.Now.ToString(),
                login = tb_login.Text,
                type_login = type
            };
            ConnectDB.connnectDB.history_login.Add(history_ob);
            ConnectDB.connnectDB.SaveChanges();
            try
            {
            }
            catch
            {
                MessageBox.Show("error");
            }

        }
    }
}
