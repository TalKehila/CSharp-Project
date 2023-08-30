using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class EmpolyeeManager
    {
       public List<Employee> employees = new List<Employee>();
     public   List<User> users = new List<User>();
        public void AddPerson(Object person)
        {
            if (person is User user)
            {
                users.Add(user);
            }
            else if (person is Employee employee)
            {
                employees.Add(employee);

            }
        }
        public bool IsEmployee(string usernames, string passwords)
        {
            foreach (Employee employee in employees)
            {
                if (string.Equals(usernames, employee.UserName) && string.Equals(passwords, employee.Password))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsUser(string usernames, string passwords)
        {
            foreach (User user in users)
            {
                if (string.Equals(usernames, user.UserName) && string.Equals(passwords, user.Password))
                {
                    return true;
                }
            }
            return false;
        }
       
    }
}
