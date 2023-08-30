using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Box
    {

        public int amount { get; set; }
        public DateTime expiryDate { get; set; }
        public double height { get; set; }
        public double width { get; set; }
        public string ExpDateString => expiryDate.ToLongDateString();
        public Box()
        {   
        }
        public Box(double height, double width, DateTime expiryDate, int amount)
        {
            this.amount = amount;
            this.width = width;
            this.height = height;
            this.expiryDate = expiryDate;
        }
        public override string ToString()
        {

            return $"Height: {height}, base: {width },expiryDate: {ExpDateString}, Amount: {amount}";
        }
        

    }

}
