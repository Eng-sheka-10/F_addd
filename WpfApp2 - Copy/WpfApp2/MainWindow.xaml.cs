using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.Xaml.Permissions;
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }



        private void TextBox_(object sender, TextChangedEventArgs e)
        {
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_login_usrname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (txt_login_pass.Text == "123" && txt_login_usrname.Text=="sheka10")
            {
                todolist todolist1 = new todolist();
                todolist1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("wrong user name or password ysta (~_~)");
            }

        }

    }
}
