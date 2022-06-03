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

namespace CafeManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnExit.IsEnabled = true;
            
            txtPassword.Password = "031720";
           
        }

        private void txtUserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtUserName.Focus();
        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
           txtPassword.Focus();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUserName.Text == "Minifa" && txtPassword.Password == "031720") 
            {
                Dashboard ds = new Dashboard();
                ds.BringIntoView();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
