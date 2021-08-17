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
using BenchmarkBusiness;

namespace BenchmarkWPF
{
    /// <summary>
    /// Interaction logic for RegisterUser.xaml
    /// </summary>
    public partial class RegisterUser : Window
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void tbxUserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            var userManager = new UserManager();
        }

        private void pbxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            var userManager = new UserManager();
        }

        private void pbxRepeatPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            var userManager = new UserManager();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            var userManager = new UserManager();
            
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            var userManager = new UserManager();
        }
    }
}
