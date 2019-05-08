using Models;
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

namespace ElementsLesson
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void registrationClick(object sender, RoutedEventArgs e)
        {
            User user = new User();

            var newLogin = newLoginTextBox.Text;
            var newPassword = newPasswordBox.Password;
            var confirmNewPassword = confirmPasswordBox.Password;

            if (string.IsNullOrEmpty(newLogin) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }
            if(newPassword!=confirmNewPassword)
            {
                MessageBox.Show("Passwords must be the same");
                return; 
            }
            user.Login = newLogin;
            user.Password = newPassword;

            using ()
        }
    }
}
