using BevergeProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BevergeProject
{
    internal class Coffee:Baverage
    {
        public Coffee() 
        {
            Name = "Coffee";
            Price = 15;
        }
       
        protected override string AddIngredients()
        {
          return "Adding Coffee ingrediend\n";

        }
        protected override string AddWater()
        {
            return "Adding water with 100 degrees\n";
        }
        protected override string StirBeverge()
        {
           return "Strring your coffee\n";
        }
    }
}
