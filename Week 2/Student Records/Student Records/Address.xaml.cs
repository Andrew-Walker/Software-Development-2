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
    /// Interaction logic for Address.xaml
    /// </summary>
    public partial class Address : Window {
        public string PublicAddress {
            get { return fullAddress; }
        }

        String fullAddress = "";
        public Address() {
            InitializeComponent();
        }

        private void okButton_Click(object sender, RoutedEventArgs e) {
            fullAddress = numberTextBox.Text + ", " + streetTextBox.Text + ", " + cityTextBox.Text + ", " + postcodeTextBox.Text + ", " + countryTextBox.Text;

            this.Hide();
        }
    }
}
