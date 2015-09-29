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

namespace Bank_Account {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private double balance = 0;
        private String inputString = "";
        private double inputValue = 0;

        public MainWindow() {
            InitializeComponent();
        }

        private void Credit_Button_Click(object sender, RoutedEventArgs e) {
            if (Double.TryParse(inputString, out inputValue)) {
                if ((balance + inputValue) >= 0) {
                    balance += inputValue;
                    balanceLabel.Content = "Your current bank balance is £" + balance;

                    transactionListBox.Items.Add("Credited: £" + inputValue + ", Balance: £" + balance);
                } else {
                    MessageBoxResult result = MessageBox.Show("Invalid entry");
                }
            } else {
                MessageBoxResult result = MessageBox.Show("Invalid entry");
            }
        }

        private void Debit_Button_Click(object sender, RoutedEventArgs e) {
            if (Double.TryParse(inputString, out inputValue)) {
                if ((balance - inputValue) >= 0) {
                    balance -= inputValue;
                    balanceLabel.Content = "Your current bank balance is £" + balance;

                    transactionListBox.Items.Add("Debited: £" + inputValue + ", Balance: £" + balance);
                } else {
                    MessageBoxResult result = MessageBox.Show("Invalid entry");
                }
            } else {
                MessageBoxResult result = MessageBox.Show("Invalid entry");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var textBox = sender as TextBox;
            inputString = textBox.Text;
        }
    }
}
