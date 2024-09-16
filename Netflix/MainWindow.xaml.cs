using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Netflix
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;

        public MainWindow()
        {
            InitializeComponent();
            // Start a timer when the MainWindow is loaded
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Initialize a dispatcher timer
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(3); // Set the timer for 5 seconds
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop(); // Stop the timer to avoid repeating

            // Navigate to the next page
            Profile profilePage = new Profile();
            MainFrame.Navigate(profilePage); // Use the Frame to navigate

        }
    }
}