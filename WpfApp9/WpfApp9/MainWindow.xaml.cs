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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ShopEntities BD = new ShopEntities();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Login = Tb1.Text.ToString();
            string Password = Tb2.Text.ToString();
            

            try
            {
                var dd = BD.User.Single(s => s.log == Login && s.pass == Password);
                q.Navigate(new Page1());
                
            }
            catch 
            
            {
                MessageBox.Show("Неверные данные");
            }
        }
    }
}
