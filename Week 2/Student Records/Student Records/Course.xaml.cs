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

namespace Student_Records {
    /// <summary>
    /// Interaction logic for Course.xaml
    /// </summary>
    public partial class Course : Window {
        public string PublicCourse {
            get { return courseSelected; }
        }

        String courseSelected = "";
        public Course() {
            InitializeComponent();
        }

        private void okButton_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void courseComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var comboBox = sender as ComboBox;

            courseSelected = comboBox.SelectedItem as string;
        }

        private void courseComboBox_Loaded(object sender, RoutedEventArgs e) {
            List<string> courses = new List<string>();
            courses.Add("Computing");
            courses.Add("Mathematics");
            courses.Add("Art");
            courses.Add("Music");

            var comboBox = sender as ComboBox;

            //Add items to combo box
            comboBox.ItemsSource = courses;

            //Set the default selection to the first item
            comboBox.SelectedIndex = 0;
        }
    }
}
