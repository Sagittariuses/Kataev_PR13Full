using RMP_PR11.LocalClasses;
using RMP_PR11.Model;
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

namespace RMP_PR11.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        AirlineEntities db = Helper.GetContext();
        public ClientsPage()
        {
            InitializeComponent();
            ClientsLV.ItemsSource = db.Client.ToList();
            ClientTypesLV.ItemsSource = db.ClientType.ToList();
        }
    }
}
