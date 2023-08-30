using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Threading;

namespace BevergeProject
{
   abstract class Baverage
    {
        private string name;
        private double price;     
        public string Name
        {
            get { return name; }
            set { name = value; }
        }     
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        protected abstract  string AddIngredients();
        protected abstract string AddWater();
        protected  abstract  string StirBeverge();
        public virtual string MakingIt()
        {
            string preparation = "";
            preparation = AddIngredients();
            preparation += AddWater() ;
            preparation += StirBeverge();          
            return preparation;
            
        }
    }
}

