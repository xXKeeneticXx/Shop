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

namespace WpfApp9
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        ShopEntities BD = new ShopEntities();
        public Page3()
        {
            InitializeComponent();
            Dg.ItemsSource = BD.User.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            b.Navigate(new Page4());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            b.Navigate(new Page1());
        }

        
    }
}
