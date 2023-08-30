using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BevergeProject
{
    internal class Tea :Baverage
    {      
        public Tea()
        {
            Name = "Green Tea";
            Price = 12;
        }     
        protected override string AddIngredients()
        {                   
            return "Adding your leaves\n"; 
        }
        protected override string AddWater()
        {                    
            return "Adding water with 150 degrees\n";           
        }
        protected override string StirBeverge()
        {
            return "Strring your tea\n";
        }
    }
}
