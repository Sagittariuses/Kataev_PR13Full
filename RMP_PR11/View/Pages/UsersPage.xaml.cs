using RMP_PR11.LocalClasses;
using RMP_PR11.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        AirlineEntities db = Helper.GetContext();
        public UsersPage()
        {
            InitializeComponent();
            UsersLV.ItemsSource = db.Users.ToList();
        }

        private void AddNewUser_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"E:\Other\repos\RMP_PR11_rya\AddDataToDB\bin\Debug\AddDataToDB.exe");
            if(check())
            {
                UsersLV.ItemsSource = db.Users.ToList();
            }
        }

        public bool check()
        {
            foreach (Process process in Process.GetProcessesByName("AddDataToDB.exe"))
            {
                return true;
            }
            check();
            return true;

        }
    }
}
