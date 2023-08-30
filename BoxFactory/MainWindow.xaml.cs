using Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

namespace BoxProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Manager manager;
        
       // public ObservableCollection<Box>  ListOfExp { get;set; }
       // public ObservableCollection<Box> boxListGoodExp { get; set; }
        static int i = 0;
        public Box BoxChoice { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            manager = new(BoxInfo);
          //  ListOfExp = new ObservableCollection<Box>();
          //  boxListGoodExp = new ObservableCollection<Box>();
            //MyBst MyBst = new();
            //boxList = MyBst.allboxes;
            loadBox();
            DataContext = this;
            addbox();
            
        }
        public void addbox()
        {
           Box box1= new Box(9, 5.6, DateTime.Now.AddDays(-1), 5);
            Box box2 = new Box(8, 4.4, DateTime.Now.AddDays(5), 5);
            Box box3= new Box(12, 7.5, DateTime.Now.AddDays(6), 5);
            Box box4 = new Box(6, 4.5, DateTime.Now.AddDays(-7), 5);
            Box box5 = new Box(7, 4.5, DateTime.Now.AddDays(-9), 5);

            //boxList.Add(box1);
            //boxList.Add(box2);
            //boxList.Add(box3);
            //boxList.Add(box4);
            //boxList.Add(box5);
            manager.AddBox(box1);
            manager.AddBox(box2);
            manager.AddBox(box3);
            manager.AddBox(box4);
            manager.AddBox(box5);
            loadBox();
        }
        public void loadBox()
        {

            ListGoodExp.Items.Clear();
            ListOfExpBox.Items.Clear();
            foreach (var item in manager.Collection)
            {
                if(item.expiryDate< DateTime.Now)
                    ListOfExpBox.Items.Add(item);
                else
                    ListGoodExp.Items.Add(item);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //(BoxAvilable) the name if the list view for good boxes 
            //(ListOfExpBox) the name of the list view of boxes that expired 
            BoxWidth.Text += "aku" + (i++) + "\n";
            //BoxHeight.Text;
            //BoxQuantity;
            //xbox.Text = i % 2 != 0 ? "dont push me " : "Odd";
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
            }
            else
            {
                MessageBox.Show("Invalid details. Please try again.");
            }
        }
        private void BtnSeacrhClick(object sender, RoutedEventArgs e)
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

            if (BoxChoice == null)
            {     
               
                MessageBox.Show("There are no boxes matching what you requested");
            }
            else
            {
                MessageBox.Show("the box is found " + BoxChoice);
                BoxInfo.Text= BoxChoice.ToString();
            }
            var founditem = true;
            if (founditem)
            {
                BtnBuy.Visibility = Visibility.Visible;
            }
            
          
        }

        private void BtnBuy_Click(object sender, RoutedEventArgs e)
        {
            
            manager.RemoveBox(b,b.amount);
            loadBox();
            BtnBuy.Visibility = Visibility.Hidden;
        }
    }
}
