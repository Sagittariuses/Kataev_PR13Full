using RMP_PR11.LocalClasses;
using RMP_PR11.Model;
using RMP_PR11.View;
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

namespace RMP_PR11
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        AirlineEntities db = Helper.GetContext();
        private void btnAuthorization_Click(object sender, RoutedEventArgs e)
        {

        if (TBLogin.Text != "" && TBPswrd.Text != "")
            {
                try
                {
                    string chekLog = db.Users.ToList().Find(x => x.Login.StartsWith(TBLogin.Text)).Login;
                    if (TBLogin.Text == chekLog)
                    {
                        string hash = Hashing.PasswordHashing(TBPswrd.Text);
                        if (hash == db.Users.Where(x => x.Login == chekLog).ToList().Find(b => b.UserID > 0).Password)
                        {
                            if (Convert.ToString(db.Users.Where(a => a.Login == chekLog).ToList().Find(b => b.UserID > 0).Role) == "A")
                            {
                                MenuSystem menuSystem = new View.MenuSystem();
                                menuSystem.Show();
                                this.Close();
                        }
                            else
                            {
                                UserWindow userWindow = new UserWindow();
                                userWindow.Show();
                                this.Close();
                            }
                        }
                    }
                }
                catch
                {
                }

            }

        }

    }
}
