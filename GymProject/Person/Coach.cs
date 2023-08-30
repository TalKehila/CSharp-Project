using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gym
{
    [Serializable]
    class Coach : Person
    {
        private string employeeID;
        private string bankNumber;
        private string profession;
        private string grade;
        private string status;


        Coach[] ArrCoach = new Coach[70];
       int ArrCoachIndex = 0;
        public Coach () : base()
        {
            this.employeeID = " ";
            this.bankNumber = " ";
            this.profession = " ";
           
        }

        public void NewCoach() //Method for new coach +person details 
        {
            CheckInfo();
            PrintEmpoleeID();
            getBankNumber();
            Getprofession();
            
            //string SaveCoach = JsonConvert.SerializeObject(this);// this is the same object of the class 
            //File.AppendAllText("Coach.txt", SaveCoach);//appendalltext 

        }
        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; } 
        }
       
            public void PrintEmpoleeID()
            {
                Random rndEmpoleeID = new Random();
                int num;         
                   num = rndEmpoleeID.Next(1, 500);
              
                employeeID = num.ToString("D3");
                Console.WriteLine("Your employee ID is: " + employeeID);
            }


       
   
        public string BankNumber
        {
            get { return bankNumber; }
            set
            {
                string Rbanknumber = @"^\d{5,20}$";
                Regex rBanknumber = new Regex(Rbanknumber);
                if (rBanknumber.IsMatch(value))
                    bankNumber = value;
            }
        }
        public void getBankNumber()
        {
            Console.WriteLine("enter you bank number ");
            BankNumber = Console.ReadLine();
            while (!Regex.IsMatch(BankNumber, @"^\d{5,20}$"))
            {
                Console.WriteLine("someting with your bank number worng enter again ");
                BankNumber = Console.ReadLine();
            }
            Console.WriteLine(" your bank number for payroll is : " + BankNumber);
        }

        public string Profession
        {
            get { return profession; }
            set
            {
                string rProfession = @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+){1,30}$";
                Regex Rprofession = new Regex(rProfession);
                if (Rprofession.IsMatch(value))
                    profession = value;
            }
        }
        public void Getprofession()
        {
            Console.WriteLine("Write your profession");
            Profession = Console.ReadLine();
            while (!Regex.IsMatch(Profession, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+){1,30}$"))
            {
                Console.WriteLine(" enter profession again ");
                Profession = Console.ReadLine();

            }
        }

    }

}
