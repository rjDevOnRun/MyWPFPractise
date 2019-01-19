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

namespace WPFPractise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<TestUser> users = new List<TestUser>();

        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = this;  //UPDATESOURCETRIGGER EXAMPLE

            users.Add(new TestUser() { Name = "John Doe" });
            users.Add(new TestUser() { Name = "Jane Doe" });

            lbUsers.ItemsSource = users;
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new TestUser() { Name = "New user" });
        }

        private void btnChangeUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
                (lbUsers.SelectedItem as TestUser).Name = "Random Name";
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
                users.Remove(lbUsers.SelectedItem as TestUser);
        }

    }


    public class TestUser
    {
        public string Name { get; set; }
    }
}



/* ************************* UPDATESOURCETRIGGER EXAMPLE **************************
//private void btnUpdateSource_Click(object sender, RoutedEventArgs e)
//{
//    BindingExpression binding = txtWindowTitle.GetBindingExpression(TextBox.TextProperty);
//    binding.UpdateSource();
//}
 ************************** UPDATESOURCETRIGGER EXAMPLE *************************** */