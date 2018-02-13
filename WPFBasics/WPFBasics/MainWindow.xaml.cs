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

namespace WPFBasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void applyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is: {this.descriptionText.Text}");
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            this.weldCheckBox.IsChecked = false;
            this.assemblyCheckBox.IsChecked = false;
            this.sawCheckBox.IsChecked = false;
            this.plasmaCheckBox.IsChecked = false;
            this.laserCheckBox.IsChecked = false;
            this.latheCheckBox.IsChecked = false;
            this.rollCheckBox.IsChecked = false;
            this.foldCheckBox.IsChecked = false;
            this.purchaseCheckBox.IsChecked = false;
            this.drillCheckBox.IsChecked = false;

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            string codeValue = (string)((CheckBox)sender).Content;
            this.orderCodeText.Text += (codeValue[0] + " ");
        }
    }
}
