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
using System.Diagnostics;
using RMP_PR11.View.Pages;

namespace RMP_PR11.View
{
    /// <summary>
    /// Логика взаимодействия для MenuSystem.xaml
    /// </summary>
    public partial class MenuSystem : Window
    {
        public MenuSystem()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Users_Click(object sender, RoutedEventArgs e)
        {
            UsersPage usersPage = new UsersPage();
            MainFrame.Navigate(usersPage);
        }

        private void Shedule_Click(object sender, RoutedEventArgs e)
        {
            ShedulesPage shedulePage = new ShedulesPage();
            MainFrame.Navigate(shedulePage);
        }

        private void Clients_Click(object sender, RoutedEventArgs e)
        {
            ClientsPage clientsPage = new ClientsPage();
            MainFrame.Navigate(clientsPage);
        }

        private void Planes_Click(object sender, RoutedEventArgs e)
        {
            PlanesPage planes = new PlanesPage();
            MainFrame.Navigate(planes);
        }

        private void Stuffs_Click(object sender, RoutedEventArgs e)
        {
            StuffsPage stuffs = new StuffsPage();
            MainFrame.Navigate(stuffs);
        }

        private void Suppliers_Click(object sender, RoutedEventArgs e)
        {
            SuppliersPage suppliers = new SuppliersPage();
            MainFrame.Navigate(suppliers);
        }

        private void TicketInfos_Click(object sender, RoutedEventArgs e)
        {
            TicketsPage tickets = new TicketsPage();
            MainFrame.Navigate(tickets);
        }

        private void Applications_Click(object sender, RoutedEventArgs e)
        {
            ApplicationsPage applications = new ApplicationsPage();
            MainFrame.Navigate(applications);
        }
    }
}
