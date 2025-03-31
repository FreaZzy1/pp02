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
using MySql.Data.MySqlClient;
using PP02_Cheremnykh.Classes;

namespace PP02_Cheremnykh.Elements
{
    /// <summary>
    /// Логика взаимодействия для Car.xaml
    /// </summary>
    public partial class Car : UserControl
    {
        public CarContext carContext;

        public Car(CarContext AllCar)
        {
            InitializeComponent();
            carContext = AllCar;
            Name.Content = "Имя" + AllCar.Name;
            Marks.Content = "Марка" + AllCar.Name;
            Gos_Number.Content = "Гос номер" + AllCar.Gos_Number;
            Voditel.Content = "Водитель" + AllCar.Voditel;
        }
            private void Click_Change(object sender, RoutedEventArgs e)
            {

            MainWindow.init.frame.Navigate(new Pages.EditCar(carContext));
            }

        private void Click_Delete(object sender, RoutedEventArgs e)
        {
            MySqlConnection connecction = Classes.WorkingBD.Connection.OpenConnection();
            Classes.WorkingBD.Connection.Query($"Delete From Car Where Id = '{carContext.Id}'", connecction);
            Classes.WorkingBD.Connection.CloseConnection(connecction);
            MainWindow.AllCar = CarContext.AllCar();
            MainWindow.init.OpenPages(MainWindow.pages.car);
            MessageBox.Show($"Товар удален", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}

