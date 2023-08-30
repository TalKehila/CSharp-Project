using System.Text.RegularExpressions;
namespace Gym
{
    [Serializable]
    abstract class Person
    {
        private string taxId;
        private string firstName;
        private string lastName;
        private string gender;
        private DateTime birth; 
        private string phone; 
        private string email; 
        public Person()
        {
            this.taxId = " ";
            this.firstName = " ";
            this.lastName = " ";
            this.gender = " ";
            this.phone = " ";
            this.email = " ";
            this.birth = DateTime.Parse("1800-04-14");
           
        }
       

        

        public void CheckInfo()//method for checking every  field i have 
        {
            Console.WriteLine("General registration form");
            SetFname();
            SetLName();
            SetGender();
            SetId();
            SetEmail();
            Setphone();
            Setbirth();
        }
        public string TaxId
        {
            get { return taxId; }
            set
            {
                string rTaxId = @"^[0-9]{9}$";
                Regex RtaxId = new Regex(rTaxId);
                if (RtaxId.IsMatch(value))
                    taxId = value;
            }
        }
        public void SetId()
        {
            Console.WriteLine("enter ID ");
            TaxId = Console.ReadLine();
            while (!Regex.IsMatch(TaxId, @"^[0-9]{9}$"))
            {
                Console.WriteLine("The ID is worng enter again ");
                TaxId = Console.ReadLine();
            }
        }
        public string Firstname
        {
            get { return firstName; }
            set
            {
                string rFirstname = @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$";
                Regex RfirstName = new Regex(rFirstname);
                if (RfirstName.IsMatch(value))
                { firstName = value; }
            }
        }
        public void SetFname()
        {
            Console.WriteLine("enter your first name");
            Firstname = Console.ReadLine();
            while (!Regex.IsMatch(Firstname, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$"))
            {
                Console.WriteLine("invild name enter again ");
                Firstname = Console.ReadLine();
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                string rLastname = @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$";
                if (new Regex(rLastname).IsMatch(value))
                    lastName = value;
            }
        }
        public void SetLName()
        {
            Console.WriteLine("enter your last name");
            LastName = Console.ReadLine();
            while (!Regex.IsMatch(LastName, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$"))
            {
                Console.WriteLine("invild  last name enter again");
                LastName = Console.ReadLine();
            }
        }
        public string Gender
        {
            get { return gender; }
            set
            {
                string rGender = @"^(M|m|F|f)$";
                Regex Rgender = new Regex(rGender);
                if (Rgender.IsMatch(value))
                    gender = value;
            }
        }
        public void SetGender()
        {
            Console.WriteLine("enter your gender M m or F f  ");
            Gender = Console.ReadLine();
            while (!Regex.IsMatch(Gender, @"^(M|m|F|f)$"))
            {
                Console.WriteLine(" Invalid Gender answer enter again");
                Gender = Console.ReadLine();
            }
        }
        public DateTime Birth 
        {
            get { return birth; }
            set
            {
                string rBirth = @"^(19[5-9][0-9]|20[0-1][0-9]|2022)-(0?[1-9]|1[0-2])-(0?[1-9]|[1-2][0-9]|3[0-1])$";
                Regex Rbirth = new Regex(rBirth); /// event of regex to get the parameters 
                if (Rbirth.IsMatch(value.ToString(("yyyy-MM-dd"))))  /// check if input if clear 
                    birth = value; // if the input is true. set the birth to its value 
            }
        }
        public void Setbirth()
        {
            Console.WriteLine("Enter your birth date in this format: yyyy-MM-dd");

            while (true)
            {
                string date = Console.ReadLine();

                if (Regex.IsMatch(date, @"^(19[5-9][0-9]|20[0-1][0-9]|2022)-(0?[1-9]|1[0-2])-(0?[1-9]|[1-2][0-9]|3[0-1])$"))
                {
                    try
                    {
                        Birth = DateTime.Parse(date);// when the user put input  the mehod checking the the input 
                        Console.WriteLine("Your birth date is: " + Birth);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid date entered. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid format. Please enter the date in the format: yyyy-MM-dd");
                }
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                string rPhonenumber = @"^05[0-9]{1}-?[0-9]{3}-?[0-9]{4}$";
                Regex RphoneNumber = new Regex(rPhonenumber);
                if (RphoneNumber.IsMatch(value))
                    phone = value;
            }
        }
        public void Setphone()
        {
            Console.WriteLine("enter your phone");///////////////////////////////////////////phone method
            Phone = Console.ReadLine();
            while (!Regex.IsMatch(Phone, @"^05[0-9]{1}-?[0-9]{3}-?[0-9]{4}$"))
            {
                Console.WriteLine(" phone number is not coreect enter again ");
                Phone = Console.ReadLine();
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                string rEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                Regex Remail = new Regex(rEmail);
                if (Remail.IsMatch(value))
                    email = value;
            }
        }

        public void SetEmail()
        {
            Console.WriteLine("enter your email");
            Email = Console.ReadLine();
            while (!Regex.IsMatch(Email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                Console.WriteLine(" enter email again ");
                Email = Console.ReadLine();
            }
        }

        public string GetFullName()
        {
            return Firstname + " " + LastName;
        }
    }
}
