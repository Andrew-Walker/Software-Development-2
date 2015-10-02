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

namespace Student_Record_System {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window {
        Student newStudent = new Student();
        Award awardWindow = new Award();

        public MainWindow() {
            InitializeComponent();
        }

        public static int Validation(string inputString) {
            //Validates that values entered can be converted to an int

            int outputInt;

            if (!int.TryParse(inputString, out outputInt)) {
                Console.WriteLine("Validation failed");
            }

            return outputInt;
        }

        private void clearButton_Click(object sender, RoutedEventArgs e) {
            foreach (UIElement element in studentForm.Children) {
                //Loops through all UIElements on window to find text boxes

                TextBox textBox = element as TextBox;
                if (textBox != null && textBox != levelTextBox) {
                    //Sets textbox contents to empty unless textbox is level

                    textBox.Text = String.Empty;
                }
            }

            levelTextBox.Text = "1";
        }

        private void setButton_Click(object sender, RoutedEventArgs e) {
            //Sets and validates data entered to text boxes

            int validationMatric = Validation(matricNumberTextBox.Text);
            int validationLevel = Validation(levelTextBox.Text);
            int validationCredits = Validation(creditsTextBox.Text);

            newStudent.MatriculationNumber = validationMatric;
            newStudent.FirstName = firstNameTextBox.Text;
            newStudent.SecondName = secondNameTextBox.Text;
            newStudent.DateOfBirth = dateOfBirthTextBox.Text;
            newStudent.Course = courseTextBox.Text;
            newStudent.Level = validationLevel;
            newStudent.Credits = validationCredits;
        }

        private void advanceButton_Click(object sender, RoutedEventArgs e) {
            //Validates and advances student level

            int validationCredits = Validation(creditsTextBox.Text);
            newStudent.Credits = validationCredits;

            newStudent.advance();

            levelTextBox.Text = (newStudent.Level).ToString();
        }

        private void getButton_Click(object sender, RoutedEventArgs e) {
            //Gets data from class to populate text boxes

            matricNumberTextBox.Text = (newStudent.MatriculationNumber).ToString();
            firstNameTextBox.Text = newStudent.FirstName;
            secondNameTextBox.Text = newStudent.SecondName;
            dateOfBirthTextBox.Text = newStudent.DateOfBirth;
            courseTextBox.Text = newStudent.Course;
            levelTextBox.Text = (newStudent.Level).ToString();
            creditsTextBox.Text = (newStudent.Credits).ToString();
        }

        private void awardButton_Click(object sender, RoutedEventArgs e) {
            //Shows award window

            awardWindow.Show();
        }
    }
}
