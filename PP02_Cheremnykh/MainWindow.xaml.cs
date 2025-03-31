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
using PP02_Cheremnykh.Classes;

namespace PP02_Cheremnykh
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<CarContext> AllCar = CarContext.AllCar();
        public static MainWindow init;

        public MainWindow()
        {
            InitializeComponent();
        }
        public enum pages
        {
            authorization,
            main, car

        }
        public void OpenPages(pages _pages)
        {
            this.MinHeight = 800;
            this.MinWidth = 800;
            this.Height = 850;
            this.Width = 850;
        }
    }
}
