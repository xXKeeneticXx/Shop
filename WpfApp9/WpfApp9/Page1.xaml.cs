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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        ShopEntities BD = new ShopEntities();
        public Page1()
        {
            InitializeComponent();
            Dg.ItemsSource = BD.Zakaz.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

           w.Navigate(new Page3());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            w.Navigate(new Page2());
        }
    }
}
