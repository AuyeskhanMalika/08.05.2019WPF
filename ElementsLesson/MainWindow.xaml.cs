using DataAccess;
using Models;
using Services;
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

namespace ElementsLesson
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

        private void SignInButtonClick(object sender, RoutedEventArgs e)
        {
            var login = loginTextBox.Text;
            var password = passwordBox.Password;

            if(string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            using (var context = new SecurityContext())
            {
                var user = context
                    .Users
                    .FirstOrDefault(searchingUser => searchingUser.Login == login);

                if(user != null && DataEncryptor.IsValidPassword(password, user.Password))
                {
                    MessageBox.Show("Welcome!");
                }
                else
                {
                    MessageBox.Show("Go away!");
                }
            }
        }

        private void registerButtonClick(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }
    }
}
