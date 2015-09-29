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
        Address addressWindow = new Address();
        Course courseWindow = new Course();

        public MainWindow() {
            InitializeComponent();
        }

        private void courseButton_Click(object sender, RoutedEventArgs e) {
            //Create and show instance of course window
            courseWindow.Show();
            addressWindow.Owner = this;
            courseWindow.Closing += new System.ComponentModel.CancelEventHandler(courseWindow_Closing);
        }

        private void addressButton_Click(object sender, RoutedEventArgs e) {
            //Create and show instance of address window
            addressWindow.Show();
            addressWindow.Owner = this;
            addressWindow.Closing += new System.ComponentModel.CancelEventHandler(addressWindow_Closing);
        }

        void courseWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            courseLabel.Content = courseWindow.PublicCourse;
        }

        void addressWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            addressLabel.Content = addressWindow.PublicAddress;
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
