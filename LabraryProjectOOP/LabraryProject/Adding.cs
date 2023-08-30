using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using System.IO;
using System.Text.Json;
using static Logic.Item;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabraryProject
{
    public partial class Adding : Form
    {
      
        string oldName;
        double tempPrice;
        Item item;
        ItemManager manager;
        ItemManager man = ItemManager.ItemManagerInstance;
        public Adding()
        {
            InitializeComponent();
            List<Item> loadedItems = man.LoadItems();
            foreach (Item item in loadedItems)
            {
                ComboBOxx.Items.Add(item);
            }
            ComboBOxx.SelectedIndexChanged += ComboBOxx_SelectedIndexChanged;
        }
        private void ButtonAddingNewBook_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameBox.Text) ||
     (BtnBook.Checked && string.IsNullOrWhiteSpace(AuthorBox.Text)) ||
     string.IsNullOrWhiteSpace(NumPageBox.Text) ||
     string.IsNullOrWhiteSpace(RealseDateBox.Text) ||
     string.IsNullOrWhiteSpace(ISBNBOX.Text) ||
     string.IsNullOrWhiteSpace(TypeBox.Text) ||
     string.IsNullOrWhiteSpace(RentBox.Text) ||
     (!JournalBTN.Checked && !BtnBook.Checked && !BtnEdit.Checked))
            {
                MessageBox.Show("Please fill in all the fields and select an item type.");
                return;
            }
            else
            {

                if (JournalBTN.Checked)
                {
                    item = new Journal();                  
                }
                else if (BtnBook.Checked)
                {
                    item = new Book();
                    if (item is Book book1)
                    {
                        book1.Author = AuthorBox.Text;
                        
                    }
                }
                item.Name = NameBox.Text;
                item.Pages = NumPageBox.Text;
                item.ReleaseDate = RealseDateBox.Text;
                item.ISBN = ISBNBOX.Text;
                item.Type = TypeBox.Text;
                if (item is Book book)
                {
                    book.Author = AuthorBox.Text;

                }
                try
                {
                    if (double.TryParse(RentBox.Text, out tempPrice))
                    {
                        item.Price = tempPrice;
                        item.ItemType = item.GetType().ToString();
                        if (double.TryParse(RentBox.Text, out double val))
                            if (double.TryParse(DisBox.Text, out double discount))
                                item.Price = man.Discount(val, discount);
                        if (JournalBTN.Checked || BtnBook.Checked)
                        {
                            man.AddItem(item);
                            man.fileManager.SaveItem(item);
                        }
                        else if (BtnEdit.Checked)
                        {
                            man.EditItem(item, oldName);
                        }
                        MessageBox.Show("Item saved successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Invalid price.");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid price.");
                }
                bool isEmployee = true;
                EmpolyeeLogInPage empolyeeLogInPage = new EmpolyeeLogInPage(man, isEmployee);
                empolyeeLogInPage.Show();
                this.Hide();
                this.Close();
            }
        }
        private void BtnBackToMenu_Click_1(object sender, EventArgs e)
        {
            bool isEmployee = true;
            EmpolyeeLogInPage empolyeeLogInPage = new EmpolyeeLogInPage(man, isEmployee);
            empolyeeLogInPage.Show();
            this.Hide();
            this.Close();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (JournalBTN.Checked)
            {
                ISBNBOX.Visible = true;
            }
        }
        private void RentBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void BtnBook_CheckedChanged_1(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        private void JournalBTN_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();

        }
        private void ComboBOxx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBOxx.Items[ComboBOxx.SelectedIndex] is Item i) { oldName = i.Name; }
            item = (Item)ComboBOxx.SelectedItem;
            NameBox.Text = item.Name;
            TypeBox.Text = item.Type;
            NumPageBox.Text = item.Pages;
            RealseDateBox.Text = item.ReleaseDate;
            RentBox.Text = item.Price.ToString();
            ISBNBOX.Text = item.ISBN;          
            if (item is Book book)
            {
                AuthorBox.Text = book.Author;               
            }
        }
        private void BtnEdit_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void ClearTextBoxes()
        {
            NameBox.Clear();
            TypeBox.Clear();
            NumPageBox.Clear();
            RealseDateBox.Clear();
            AuthorBox.Clear();
            RentBox.Clear();
            ISBNBOX.Clear();
        }

        private void DisBox_TextChanged(object sender, EventArgs e)
        {
        }
       
    }
}
