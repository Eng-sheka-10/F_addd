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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for todolist.xaml
    /// </summary>
    public partial class todolist : Window
    {
        public todolist()
        {
            InitializeComponent();
        }
 
        private void add(object sender, RoutedEventArgs e)
        {
            list_view.Items.Add(input_task.Text);
            input_task.Clear();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            this.Close();
        }

        private void remove_task_clicked_Click_1(object sender, RoutedEventArgs e)
        {

                list_view.Items.Remove(list_view.SelectedItem);
            
        }
    }

}
