using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using static Logic.Item;
using Logic;
using Newtonsoft.Json;

namespace Logic
{
    public class ItemManager
    {    
        List<Item> items = new List<Item>();
        static ItemManager itemManager;
        public EmpolyeeManager employeeManager;
        public FlieManager fileManager;

        public ItemManager()
        {
            fileManager=new FlieManager();
            employeeManager= new EmpolyeeManager();
            Employee e1 = new Employee("tal", "1");
            User user1 = new User("avi", "123");
            employeeManager.employees.Add(e1);
            employeeManager.users.Add(user1);           
        }
        public static ItemManager ItemManagerInstance
        {
            get
            {
                if (itemManager == null)
                    itemManager = new ItemManager();
                return itemManager;
            }
        }
        public List<Item> Items
        {
            get
            {
                return items;
            }
        }
        public void AddItem(Item item)
        {
            items.Add(item);
        }       
        public void EditItem(Item item,string oldName)
        {
            string folderPath = "MYItem";
            string fileName = $"Save {oldName}.txt";
            string fullPath = Path.Combine(folderPath, fileName);
            File.Delete(fullPath);
            fileName = $"Save {item.Name}.txt";
            fullPath = Path.Combine(folderPath, fileName);      
            string tmpitem = JsonConvert.SerializeObject(item);
            File.WriteAllText(fullPath, tmpitem);
            
        }    
        public List<Item> LoadBorrowitem()
        {
            string folderPath = "Borrow";
            List<Item> loadedItem = new List<Item>();
            string[] fliePath = Directory.GetFiles(folderPath);
            foreach (string flie in fliePath)
            {
                string Json = File.ReadAllText(flie);

                if (Json.Contains("Journal"))
                {
                    Item Journal = JsonConvert.DeserializeObject<Journal>(Json)!;
                    loadedItem.Add(Journal);
                }
                else if (Json.Contains("Book"))
                {
                    Item book = JsonConvert.DeserializeObject<Book>(Json)!;
                    loadedItem.Add(book);
                }
            }
            return loadedItem;
        }
        public List<Item> LoadItems()
        {
            string folderPath = "MYItem";        
            List<Item> loadedItem = new List<Item>();
            string[] fliePath = Directory.GetFiles(folderPath);
            foreach (string flie in fliePath)
            {
                string Json = File.ReadAllText(flie);

                if (Json.Contains("Journal"))
                {
                    Item Journal = JsonConvert.DeserializeObject<Journal>(Json)!;
                    loadedItem.Add(Journal);
                }
                else if (Json.Contains("Book"))
                {
                    Item book = JsonConvert.DeserializeObject<Book>(Json)!;
                    loadedItem.Add(book);
                }
            }     
            return loadedItem;
        }
        public void DeleteItem(Item selectedItem)
        {
            items.Remove(selectedItem);
        }
      
        public double Discount(double itemPrice, double discountAmount)
        {
            if (itemPrice <= 0 || discountAmount < 0)
            {
                throw new ArgumentException("Invalid item price or discount amount.");
            }
            double discountedPrice = itemPrice - discountAmount;
            return Math.Max(discountedPrice, 0); 
        }
    }
}
