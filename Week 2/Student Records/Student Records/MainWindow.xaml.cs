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

namespace Student_Records {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void courseButton_Click(object sender, RoutedEventArgs e) {
            //Create and show instance of course window
            Course courseWindow = new Course();
            courseWindow.Show();
        }

        private void addressButton_Click(object sender, RoutedEventArgs e) {
            //Create and show instance of address window
            Address addressWindow = new Address();
            addressWindow.ShowDialog();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e) {
            //Clear text boxes and display message
            nameTextBox.Text = "";
            maltriculationTextBox.Text = "";

            MessageBoxResult result = MessageBox.Show("New student details being added");
        }

        private void quitButton_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }
    }
}
