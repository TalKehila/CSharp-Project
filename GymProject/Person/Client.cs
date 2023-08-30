using Gym;
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

    class Client : Person
    {
        private string cardToken = "";
        private string medicalLimit = " ";
        private string height = " ";
        private string weight = " ";
        private string fatPercent = " ";
        public Client() : base()
        {
            this.cardToken = " ";
            this.medicalLimit = "";
            this.height = "";
            this.weight = "";
            this.fatPercent = "";
           
        }// constrctor 

        public void NewClient()
        {
            CheckInfo();// method for make person 
            getHeight();
            getweight();
            Getfatprecent();
            GetMedical();
            GetCardtoken();
            //    //string SaveClient = JsonConvert.SerializeObject(this);
            //    //File.WriteAllText("Client.txt", SaveClient + Environment.NewLine);

            }
        public string CardToken
        {
            get { return cardToken; }
            set
            {
                string RcardToken = @"^\d{5,20}$";
                Regex rCradtoken = new Regex(RcardToken);
                if (rCradtoken.IsMatch(value))

                    cardToken = value;
            }
        }
        public void GetCardtoken()
        {
            Console.WriteLine("enter you card token ");
            CardToken = Console.ReadLine();
            while (!Regex.IsMatch(CardToken, @"^\d{5,20}$"))
            {
                Console.WriteLine("someting with your card token worng enter again ");
                CardToken = Console.ReadLine();
            }
            Console.WriteLine(" your card token is  : {0} ", CardToken);
        }
        public string MedicalLimit
        {
            get { return medicalLimit; }
            set
            {
                string rMedical = @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+){1,30}$";
                Regex Rmedical = new Regex(rMedical);
                if (Rmedical.IsMatch(value))
                    medicalLimit = value;
            }
        }
        public void GetMedical()
        {
            Console.WriteLine("write you medical condition up to 30 Characters");
            MedicalLimit = Console.ReadLine();
            while (!Regex.IsMatch(MedicalLimit, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+){1,30}$"))
            {
                Console.WriteLine("The details you entered are incorrect, please re-enter your medical condition up to 30 characters");
                MedicalLimit = Console.ReadLine();
            }
            Console.WriteLine(" your medical condition is : {0} ", MedicalLimit);
        }
        public string Height
        {
            get { return height; }
            set
            {
                string rHeight = @"^[12]\.\d{2}$";
                Regex RHeight = new Regex(rHeight);
                if (RHeight.IsMatch(value))
                    height = value;
            }
        }
        public void getHeight()
        {
            Console.WriteLine("enter you Height (e.g exmple 1.75)");
            Height = (Console.ReadLine());
            while (!Regex.IsMatch(Height, @"^[12]\.\d{2}$"))
            {
                Console.WriteLine("uncorrct height enter again  ");
                Height = Console.ReadLine();
            }
            Console.WriteLine("your Height is : " + Height + " M ");
        }
        public string Weight
        {
            get { return weight; }
            set
            {
                string rWeight = @"^[0-9]{2,3}$";
                Regex Rweight = new Regex(rWeight);
                if (Rweight.IsMatch(value))
                    weight = value;
            }
        }
        public void getweight()
        {
            Console.WriteLine("enter your Weight");
            Weight = Console.ReadLine();
            while (!Regex.IsMatch(Weight, @"^[0-9]{2,3}$"))
            {
                Console.WriteLine("invild Weight enter again");
                Weight = Console.ReadLine();
            }
            Console.WriteLine("your weight is : " + Weight + " KG");

        }
        public string FatPercent
        {
            get { return fatPercent; }
            set
            {
                string rfatpre = @"^[0-9]{1,2}$";
                Regex Rfetpre = new Regex(rfatpre);
                if (Rfetpre.IsMatch(value))
                    fatPercent = value;
            }
        }
        public void Getfatprecent()
        {
            Console.WriteLine("enter your fat %");
            FatPercent = Console.ReadLine();
            while (!Regex.IsMatch(FatPercent, @"^[0-9]{1,2}$"))
            {
                Console.WriteLine("invild enter again");
                FatPercent = Console.ReadLine();
            }
            Console.WriteLine("your fat % is : " + FatPercent + " % ");
        }

    }

}





