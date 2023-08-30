using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BevergeProject
{
    internal class VendingMachine
    {            
        public  void Menu()
        {
          Console.WriteLine(DateTime.Now.ToString());
            Console.OutputEncoding = System.Text.Encoding.UTF8;// money mark 
            char c = '₪';
            string noStr;
            int num;
            double userPayment;
            Manger manager = new Manger();
          List<Baverage>listOfBavrage=manager.baveragesList();
            while (true) {
                Console.WriteLine($"\u001b[31mHello Hot Drink Machine choose a drink \u001b[0m");
                int index = 1;
                foreach(Baverage baverage in listOfBavrage)
                {                 
                    Console.WriteLine($"{index}. {baverage.Name}-{baverage.Price}{c}");
                    index++;
                }
                noStr = Console.ReadLine();
                if (int.TryParse(noStr, out num))
                {
                    if (num >=1 && num <= listOfBavrage.Count)
                    {
                        Baverage selectedBabervge= listOfBavrage[num-1];
                        Console.WriteLine($"You selected {selectedBabervge.Name}");
                        Console.Clear();
                        Console.WriteLine($"payment for {selectedBabervge.Name} \n the price is:{selectedBabervge.Price}{c} Please");//blue
                        Manger.PaymentUser(selectedBabervge.Price, out userPayment);                        
                        Console.WriteLine(selectedBabervge.MakingIt());
                        Console.WriteLine(manager.AddingSugar());
                       
                    }
                    else
                    {
                        Console.WriteLine("This baverage is not in the list choose again");
                    }
                }
                else
                {
                    Console.WriteLine(" try again");
                }
            }
        }       
    }
}





