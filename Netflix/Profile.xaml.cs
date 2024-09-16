using Netflix.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<ProfileModel> Profiles { get; set; }
        public Profile()
        {
            InitializeComponent();

            // Initialize the profile collection
            Profiles = new ObservableCollection<ProfileModel>
        {
            new ProfileModel { Name = "Ememalo", ImageSource = "pack://application:,,,/img/Profile1.png" },
            new ProfileModel { Name = "Onyeka", ImageSource = "pack://application:,,,/img/Profile2.png" },
            new ProfileModel { Name = "Thelma", ImageSource = "pack://application:,,,/img/Profile3.png" },
            new ProfileModel { Name = "Kids", ImageSource = "pack://application:,,,/img/Profile4.png" },
            new ProfileModel { Name = "Add Profile", ImageSource = "pack://application:,,,/img/AddProfileIcon.png" }
        };

            // Set the DataContext for data binding
            this.DataContext = this;
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // Logic for Profile 1 click
            MessageBox.Show("Edit (Ememalo) selected!");
        }
        private void Profile1_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService != null)
            {
                Home home = new Home();
                this.NavigationService.Navigate(home);
            }
        }

        private void Profile2_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService != null)
            {
                Home home = new Home();
                this.NavigationService.Navigate(home);
            }
        }

        private void Profile3_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService != null)
            {
                Home home = new Home();
                this.NavigationService.Navigate(home);
            }
        }

        private void Profile4_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService != null)
            {
                Home home = new Home();
                this.NavigationService.Navigate(home);
            }
        }

        private void AddProfile_Click(object sender, RoutedEventArgs e)
        {
            // Logic for Add Profile button
            MessageBox.Show("Add Profile button clicked!");
        }

    }
}
