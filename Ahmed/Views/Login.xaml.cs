using Ahmed.Model;
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

namespace Ahmed.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Log_in(object sender, RoutedEventArgs e)
        {
            try
            {
                var context = new std_Man_sys();

                if (string.IsNullOrWhiteSpace(txtUserName.Text))
                {
                    MessageBox.Show("Enter Valied UserName");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPassword.Password))
                {
                    txtPassword.Password = "";
                    return;
                }

                var user = context.Students.FirstOrDefault(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Password);
                if (user != null)
                {
                   
                }
                else
                {
                    invaliedData.Content = "The UserName Or Password Invalied please try again with valied date ";
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }
        private void Signup(object sender, RoutedEventArgs e)
        {
            SignUp sign = new SignUp();
            sign.Show();
            this.Close();
        }
    }
}