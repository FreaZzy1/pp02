using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace PP._11.Pages
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Page
    {
        public Autorization()
        {
            InitializeComponent();
        }
        private void Click_Authorization(object sender, RoutedEventArgs e)
        {
            string username = UserNameTextBox.Text;
            string password = PasswordBox.Password;

            if (AuthenticateUser(username, password, out string role))
            {
                if (role == "Admin")
                {
                    MessageBox.Show($"Успешный вход\nВаша роль администратор", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    MainWindow.init.OpenPages(MainWindow.pages.catalog);
                }
                else
                {
                    MessageBox.Show($"Успешный вход\nВаша роль пользователь", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    MainWindow.init.OpenPages(MainWindow.pages.catalog);
                }
            }
            else
            {
                MessageBox.Show($"Ошибка входа\nПроверьте логин и пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool AuthenticateUser(string username, string password, out string role)
        {
            role = null;
            using (var connection = new MySqlConnection("server = 127.0.0.1; port = 3306; uid = root; database = MAXXISPORT"))
            {
                connection.Open();
                using (var command = new MySqlCommand("Select Role From User Where UserName=@Username AND Password=@password", connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            role = reader.GetString(0);
                            MainWindow.UserRole = role;
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
