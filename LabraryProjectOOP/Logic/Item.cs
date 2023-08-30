namespace Logic
{
    public abstract class Item
    {
        public bool IsBorrowed { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Pages { get; set; }
        public string ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public string Type { get; set; }
        public string ItemType { get; set; }
      
    }
    public class Book : Item
    {       
        public string Author { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} , Price for Rent: {Price}";
        }
    }
    public class Journal : Item
    {      
        public override string ToString()
        {
            return $"Name: {Name} , Price for Rent: {Price}";
        }
    }

}
