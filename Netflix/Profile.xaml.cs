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

namespace Netflix
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile()
        {
            InitializeComponent();
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // Logic for Profile 1 click
            MessageBox.Show("Edit (Ememalo) selected!");
        }
        private void Profile1_Click(object sender, RoutedEventArgs e)
        {
            // Logic for Profile 1 click
            MessageBox.Show("Profile 1 (Ememalo) selected!");
        }

        private void Profile2_Click(object sender, RoutedEventArgs e)
        {
            // Logic for Profile 2 click
            MessageBox.Show("Profile 2 (Onyeka) selected!");
        }

        private void Profile3_Click(object sender, RoutedEventArgs e)
        {
            // Logic for Profile 3 click
            MessageBox.Show("Profile 3 (Thelma) selected!");
        }

        private void Profile4_Click(object sender, RoutedEventArgs e)
        {
            // Logic for Profile 4 click
            MessageBox.Show("Profile 4 (Kids) selected!");
        }

        private void AddProfile_Click(object sender, RoutedEventArgs e)
        {
            // Logic for Add Profile button
            MessageBox.Show("Add Profile button clicked!");
        }

    }
}
