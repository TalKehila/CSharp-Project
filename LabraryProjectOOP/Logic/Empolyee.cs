using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Employee
    {

        private string password;
        private string userName;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public Employee(string userName, string password)
        {
            Password = password;
            UserName = userName;
        }
    }
    public class User : Employee
    {
        
        public User(string userName, string password) : base(userName, password)
        {

        }
    }
}
