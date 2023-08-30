using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BevergeProject
{
    internal class HotChocolate : Baverage
    {
        public HotChocolate()
        {
            Name = "Hot Chocolate";
            Price = 18;
        }     
        protected override string AddIngredients()
        {              
            return "Adding your Chocolate powder\n";           
        }
        protected override string AddWater()
        {        
            return "Adding water with 60 degrees\n";
        }
        protected override string StirBeverge()
        {          
            return "Strring your choco\n";
        }
    }
}
