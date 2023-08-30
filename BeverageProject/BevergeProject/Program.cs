using BevergeProject;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Manger manger = new Manger();
            VendingMachine machine = new VendingMachine();
            machine.Menu();
            
        }
    }
}