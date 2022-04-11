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
    /// Логика взаимодействия для StuffsPage.xaml
    /// </summary>
    public partial class StuffsPage : Page
    {
        AirlineEntities db = Helper.GetContext();
        public StuffsPage()
        {
            InitializeComponent();
            StuffsLV.ItemsSource = db.Stuff.ToList();
            PostsLV.ItemsSource = db.Posts.ToList();
        }
    }
}
