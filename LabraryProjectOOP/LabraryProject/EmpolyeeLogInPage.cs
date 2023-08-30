using System.Data;
using System.Windows.Forms;
using Logic;
using static Logic.Item;

namespace LabraryProject
{
    public partial class EmpolyeeLogInPage : Form
    {
        FlieManager flieManager = new FlieManager();
        Item item;
        ItemManager _manager;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox AuthorBox;
        private System.Windows.Forms.TextBox NumPageBox;
        private System.Windows.Forms.TextBox RealseDateBox;
        private System.Windows.Forms.TextBox ISBNBOX;
        private System.Windows.Forms.TextBox TypeBox;
        bool isEmployee;
        int countborrow = 0;
        int countallitem = 0;
        public EmpolyeeLogInPage(ItemManager manager, bool isEmployee)
        {

            InitializeComponent();
            this._manager = manager;
            this.isEmployee = isEmployee;

            if (!isEmployee)
            {
                DeleteBook.Visible = false;
                ButtonAddingNewBook.Visible = false;
                TypeTextBox.Visible = false;
                TextBoxDis.Visible = false;
                Applay.Visible = false;
                Typelabel.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
            }
            List<Item> loadedItems = manager.LoadItems();
            foreach (Item item in loadedItems)
            {
                ListBoxForBookSearch.Items.Add(item);
                countallitem++;
            }
            label1.Text = countallitem.ToString();

            List<Item> borrowBooks = manager.LoadBorrowitem();
            foreach (Item item in borrowBooks)
            {
                item.IsBorrowed = true;
                BorrowBookList.Items.Add(item);
                countborrow++;
            }
            label2.Text = countborrow.ToString();
        }
        private void LabelSerachBook_Click(object sender, EventArgs e)
        {
        }
        private void ListBoxForBookSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void ButtonAddingNewBook_Click(object sender, EventArgs e)
        {
            Adding addingbook = new Adding();
            addingbook.Show();
            this.Hide();
            this.Close();
            countallitem++;
            label1.Text = countallitem.ToString();
        }
        private void ButtonBackToMenu_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
            this.Close();
        }
        private void DeleteBook_Click_1(object sender, EventArgs e)
        {
            if (ListBoxForBookSearch.SelectedItem != null)
            {
                Item selectedBook = (Item)ListBoxForBookSearch.SelectedItem;
                string folderPath = "MYItem";
                string fileName = $"Save {selectedBook.Name}.txt";
                string fullPath = Path.Combine(folderPath, fileName);
                try
                {
                    File.Delete(fullPath);
                    _manager.LoadItems();
                    ListBoxForBookSearch.Items.Remove(selectedBook);
                    MessageBox.Show("Book deleted successfully.", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting book: {ex.Message}", "Error");
                }
                countallitem--;
                label1.Text = countallitem.ToString();
            }
        }
        private void ListBoxForBookSearch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
        private void ButtonEDITBook_Click_1(object sender, EventArgs e)
        {

        }
        private void TextBoxForSearchingBook_TextChanged(object sender, EventArgs e)
        {
        }
        private void BtnSeacrh_Click(object sender, EventArgs e)
        {
            string searchText = TextBoxForSearchingBook.Text;
            ListBoxForBookSearch.Items.Clear();
            List<Item> loadedItems = _manager.LoadItems();
            List<Item> filteredItems = loadedItems.Where(item =>
                item.Name.Contains(searchText) || (item is Book book && book != null && book.Author != null && book.Author.Contains(searchText)) || item.Type.Contains(searchText)).ToList();
            foreach (Item item in filteredItems)
            {
                ListBoxForBookSearch.Items.Add(item);
            }
        }
        private void ListBoxForBookSearch_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            Item selectedMyItem = (Item)ListBoxForBookSearch.SelectedItem;
            if (selectedMyItem != null)
            {
                BookDetailsbox.Items.Clear();
                BookDetailsbox.Items.Add($" Name: {selectedMyItem.Name}");
                BookDetailsbox.Items.Add($" Type: {selectedMyItem.Type}");
                BookDetailsbox.Items.Add($" ISBN: {selectedMyItem.ISBN}");
                BookDetailsbox.Items.Add($" Release Date: {selectedMyItem.ReleaseDate}");
                BookDetailsbox.Items.Add($" Pages: {selectedMyItem.Pages}");
                if (selectedMyItem is Book book)
                {
                    BookDetailsbox.Items.Add($" Author: {book.Author}");
                }
                BookDetailsbox.Items.Add($" Price: {selectedMyItem.Price}");

            }
        }
        private void ResetSearch_Click(object sender, EventArgs e)
        {
            TextBoxForSearchingBook.Text = string.Empty;

            ListBoxForBookSearch.Items.Clear();

            List<Item> loadedItems = _manager.LoadItems();

            foreach (Item item in loadedItems)
            {
                ListBoxForBookSearch.Items.Add(item);
            }
        }
        private void ButtonEDITBook_Click(object sender, EventArgs e)
        {

        }
        private void ButtonBorrowBOOK_Click(object sender, EventArgs e)
        {
            if (ListBoxForBookSearch.SelectedItem != null)
            {
                Item selectedBook = (Item)ListBoxForBookSearch.SelectedItem;
                if (!selectedBook.IsBorrowed)
                {
                    // Update the IsBorrowed property and save the item
                    selectedBook.IsBorrowed = true;
                    _manager.fileManager.BorrowItem(selectedBook);
                    string folderPath = "MYItem";
                    string fileName = $"Save {selectedBook.Name}.txt";
                    string sourcePath = Path.Combine(folderPath, fileName);
                    folderPath = "Borrow";
                    string destinationPath = Path.Combine(folderPath, fileName);
                    try
                    {
                        // Delete the destination file if it already exists
                        if (File.Exists(destinationPath))
                        {
                            File.Delete(destinationPath);
                        }
                        File.Move(sourcePath, destinationPath);
                        BorrowBookList.Items.Add(selectedBook);
                        // Remove the book from the BorrowBookList
                        ListBoxForBookSearch.Items.Remove(selectedBook);
                        MessageBox.Show("Book returned successfully.", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error returning book: {ex.Message}", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("The book is not currently borrowed.", "Warning");
                }
            }
            countallitem--;
            label1.Text = countallitem.ToString();
            countborrow++;
            label2.Text = countborrow.ToString();
        }
        private void ReturnBppk_Click(object sender, EventArgs e)
        {
            if (BorrowBookList.SelectedItem != null)
            {
                Item selectedBook = (Item)BorrowBookList.SelectedItem;
                if (selectedBook.IsBorrowed)
                {
                    // Update the IsBorrowed property and save the item
                    selectedBook.IsBorrowed = false;
                    _manager.fileManager.SaveItem(selectedBook);
                    string folderPath = "Borrow";
                    string fileName = $"Save {selectedBook.Name}.txt";
                    string sourcePath = Path.Combine(folderPath, fileName);
                    folderPath = "MYItem";
                    string destinationPath = Path.Combine(folderPath, fileName);
                    try
                    {
                        // Delete the destination file if it already exists
                        if (File.Exists(destinationPath))
                        {
                            File.Delete(destinationPath);
                        }
                        File.Move(sourcePath, destinationPath);
                        ListBoxForBookSearch.Items.Add(selectedBook);
                        // Remove the book from the BorrowBookList
                        BorrowBookList.Items.Remove(selectedBook);
                        MessageBox.Show("Book returned successfully.", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error returning book: {ex.Message}", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("The book is not currently borrowed.", "Warning");
                }

            }
            countborrow--;
            label2.Text = countborrow.ToString();
            countallitem++;
            label1.Text = countallitem.ToString();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void ButtonSaveBook_Click(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        public void DiscountOnObject(double discountPercentage, string genre)
        {
            
            if (discountPercentage < 0)
            {
                throw new ArgumentException("Invalid discount percentage.");
            }

            foreach (Item item in _manager.LoadItems())
            {
                if (item.Type == genre)
                {

                    double discountAmount = item.Price * (discountPercentage / 100);
                    item.Price -= discountAmount;

                    _manager.EditItem(item, item.Name);
                }
            }
        }
        private void Applay_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TextBoxDis.Text, out double discountPercentage))
            {
                string genre = TypeTextBox.Text;
                DiscountOnObject(discountPercentage, genre);
            }
            else
            {
                MessageBox.Show("Invalid discount percentage.");
            }
            TextBoxForSearchingBook.Text = string.Empty;

            ListBoxForBookSearch.Items.Clear();

            List<Item> loadedItems = _manager.LoadItems();

            foreach (Item item in loadedItems)
            {
                ListBoxForBookSearch.Items.Add(item);
            }
        }

    }
}
