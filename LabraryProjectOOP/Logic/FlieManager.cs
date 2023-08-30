using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Logic; 
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Logic
{
    public class FlieManager
    {
        
        public void SaveToFile(Item item, string folderPath) // save combine iten and borrow 
        {
            string fileName = $"Save {item.Name}.txt";
            string fullPath = Path.Combine(folderPath, fileName);          
            string tmpitem = JsonConvert.SerializeObject(item);
            File.WriteAllText(fullPath, tmpitem);
        }
        public void SaveItem(Item saveItem)
        {
            string folderPath = "MYItem";
            SaveToFile(saveItem, folderPath);         
        }
        public void BorrowItem(Item saveItem)
        {
            string folderPath = "Borrow";
            SaveToFile(saveItem, folderPath);        
        }

    }
}
