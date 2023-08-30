using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BevergeProject
{
    internal class Manger
    {
        TeaWithMilk myteamilk = new TeaWithMilk();
        Coffee myCoffee = new Coffee();
        Tea myTea = new Tea();
        HotChocolate myHotChocolate = new HotChocolate();
        public List<Baverage> baveragesList()
        {
            List<Baverage> beverage = new List<Baverage>();
            beverage.Add(myCoffee);
            beverage.Add(myTea);
            beverage.Add(myHotChocolate);
            //beverage.Remove(myCoffee);
            beverage.Add(myteamilk);

            return beverage;
        }
        public static void PaymentUser(double price, out double payment)
        {
            double change = 0.0;
            payment = 0.0;
            while (price != payment)
            {
                if (!double.TryParse(Console.ReadLine(), out payment))
                {
                    Console.WriteLine("Invalid input. Please enter a valid payment amount.");
                    continue;
                }
                if (payment < price)
                {
                    Console.WriteLine($"Not enough\n add more {price -= payment} ");
                    continue;
                }
                if (payment > price)
                {
                    change = payment - price;
                    Console.WriteLine("Thank you! Here's your change: " + change);
                }
                break;
            }
        }

        public string AddingSugar()
        {
            char choice = ' ';
            while (!(choice == 'n' || choice == 'y'))
            {
                Console.WriteLine("Would you like to add sugar (y/n): ");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (choice == 'y')
                {
                    Console.WriteLine("How much sugar to add: ");
                    string sugarInput = Console.ReadLine();
                    bool validInput = false;
                    while (!validInput)
                    {
                        if (int.TryParse(sugarInput, out int number))
                        {
                            Console.WriteLine("Sugar added.");
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number: ");
                            sugarInput = Console.ReadLine();
                        }
                    }
                }
                else if (choice == 'n')
                {
                    Console.WriteLine("Not adding sugar.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                }
            }

            return "Thank you. Your beverage is ready."+ DrawCoffeeCup();
        }

        public string DrawCoffeeCup()
        {
            string coffeeCup =
                "\n"+
                "     ( ( (\n" +
                "      ) ) )\n" +
                "   ........\n" +
                "   |      |]\n" +
                "   \\      /\n" +
                "    '----'";

            return coffeeCup;
        }

    }
}


