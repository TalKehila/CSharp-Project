using Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace BoxProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Manager manager;   
        public Box BoxChoice { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            manager = new(BoxInfo);         
            loadBox();
            DataContext = this;
            addBox();
        }
        public void addBox()
        {
            Box box1 = new Box(9, 5.6, DateTime.Today.AddDays(-1), 5);
            Box box2 = new Box(8, 4.4, DateTime.Today.AddDays(5), 5);
            Box box3 = new Box(12, 7.5, DateTime.Today.AddDays(6), 5);  
            Box box4 = new Box(6, 4.5, DateTime.Today.AddDays(-7), 5);      
            manager.AddBox(box1);
            manager.AddBox(box2);
            manager.AddBox(box3);
            manager.AddBox(box4);
            loadBox();
        }
        public void loadBox()
        {
           ListGoodExp.Items.Clear();
            ListOfExpBox.Items.Clear();
            foreach (var item in manager.Collection)
            {
                if (item.expiryDate < DateTime.Now)
                   
                    ListOfExpBox.Items.Add(item);
                else
                    ListGoodExp.Items.Add(item);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void Button_Add(object sender, RoutedEventArgs e)
        {
            string textBoxValue = BoxWidth.Text;
            double convertedValueWidth = 0;
            bool isWidthValid = !string.IsNullOrWhiteSpace(textBoxValue) && double.TryParse(textBoxValue, out convertedValueWidth);

            string textBoxValue2 = BoxHeight.Text;
            double convertedValueHeight = 0;
            bool isHeightValid = !string.IsNullOrWhiteSpace(textBoxValue2) && double.TryParse(textBoxValue2, out convertedValueHeight);

            string input = BoxQuantity.Text;
            int convertedValueQuantity = 0;
            bool isQuantityValid = !string.IsNullOrWhiteSpace(input) && int.TryParse(input, out convertedValueQuantity);

            if (isWidthValid && isHeightValid && isQuantityValid)
            {

                manager.AddBox(new Box(convertedValueHeight, convertedValueWidth, DateTime.Now.AddDays(5), convertedValueQuantity));
                loadBox();
            }
            else
            {
                MessageBox.Show("Invalid details. Please try again.");
            }
        }
        private void BtnSearchClick(object sender, RoutedEventArgs e)
        {
            string textBoxValue = BoxWidth.Text;
            double convertedValueWidth = 0;
            bool isWidthValid = !string.IsNullOrWhiteSpace(textBoxValue) && double.TryParse(textBoxValue, out convertedValueWidth);

            string textBoxValue2 = BoxHeight.Text;
            double convertedValueHeight = 0;
            bool isHeightValid = !string.IsNullOrWhiteSpace(textBoxValue2) && double.TryParse(textBoxValue2, out convertedValueHeight);

            string input = BoxQuantity.Text;
            int convertedValueQuantity = 0;
            bool isQuantityValid = !string.IsNullOrWhiteSpace(input) && int.TryParse(input, out convertedValueQuantity);

            BoxChoice = manager.GetBox(convertedValueWidth, convertedValueHeight, convertedValueQuantity);
            var founditem = false;

            if (BoxChoice == null)
            {
                BoxChoice = manager.GetBoxTenPresent(convertedValueWidth, convertedValueHeight, convertedValueQuantity);
                if (BoxChoice != null)
                {
                    if (BoxChoice.expiryDate >= DateTime.Now)
                    {
                        MessageBox.Show("We don't have what you asked for, we have something up to 10% of what you asked for " + BoxChoice);
                        BoxInfo.Text = BoxChoice.ToString();
                        founditem = true;
                    }
                    else
                    {
                        MessageBox.Show("We don't have what you asked for");
                    }
                }
                else
                {
                    MessageBox.Show("There are no boxes matching what you requested" + BoxChoice);
                }
            }
            else
            {
                if (BoxChoice.expiryDate >= DateTime.Now)
                {
                    MessageBox.Show("the box is found " + BoxChoice);
                    BoxInfo.Text = BoxChoice.ToString();
                    founditem = true;
                }
                else
                {
                    MessageBox.Show("We don't have what you asked for");
                }
            }
            if (founditem)
            {
                BtnBuy.Visibility = Visibility.Visible;
            }

        }
        private void BtnBuy_Click(object sender, RoutedEventArgs e)
        {
            string input = BoxQuantity.Text;
            int convertedValueQuantity = 0;
            bool isQuantityValid = !string.IsNullOrWhiteSpace(input) && int.TryParse(input, out convertedValueQuantity);
            manager.RemoveBox(BoxChoice, convertedValueQuantity);
            loadBox();
            BtnBuy.Visibility = Visibility.Hidden;

        }
    }
}
