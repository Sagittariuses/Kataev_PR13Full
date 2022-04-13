using RMP_PR11.LocalClasses;
using RMP_PR11.Model;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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
            Process.Start(@"C:\Users\mobil\Desktop\Kataev_Practice-master\AddDataToDB\bin\Debug\AddDataToDB.exe");
            if(check())
            {
                UsersLV.ItemsSource = db.Users.ToList();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        public bool check()
        {
            foreach (Process process in Process.GetProcessesByName("AddDataToDB"))
            {
                if (process.ProcessName.ToString() == "AddDataToDB")
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    check();
                }
            }
            return true;

        }
    }
}
