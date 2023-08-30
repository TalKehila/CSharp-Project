using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BevergeProject
{
    internal class TeaWithMilk:Baverage
    {
        public TeaWithMilk()
        {
            Name = "Tea With Milk";
            Price = 21;
        }
        protected override string AddIngredients()
        {
            return "Adding your leaf and milk\n";
        }
        protected override string AddWater()
        {
            return "Adding water and milk with 60 degrees\n";
        }
        protected override string StirBeverge()
        {
            return "Strring your Tea Milk\n";
        }
    }
}
