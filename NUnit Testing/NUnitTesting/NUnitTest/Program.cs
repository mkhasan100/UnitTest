using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NUnitTest
{
    public class Program
    {


        public string Login(string UserId, string Password)
        {
            if (string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(Password))
            {
                return "Userid or password could not be Empty.";
            }
            else
            {
                if (UserId == "Admin" && Password == "Admin")
                {
                    return "Welcome Admin.";
                }
                return "Incorrect UserId or Password.";
            }
        }


        public List<EmployeeDetails> AllUsers()
        {
            List<EmployeeDetails> li = new List<EmployeeDetails>();
            li.Add(new EmployeeDetails
            {
                id = 100,
                Name = "Hasan",
                Gender = "Male",
                Salary = 40000
            });
            li.Add(new EmployeeDetails
            {
                id = 101,
                Name = "Saad",
                Gender = "Male",
                Salary = 50000
            });
            li.Add(new EmployeeDetails
            {
                id = 103,
                Name = "Saif",
                Gender = "Male",
                Salary = 40000
            });
            li.Add(new EmployeeDetails
            {
                id = 104,
                Name = "Musa",
                Gender = "Male",
                Salary = 23000
            });
            li.Add(new EmployeeDetails
            {
                id = 105,
                Name = "Asif",
                Gender = "Male",
                Salary = 80000
            });
            li.Add(new EmployeeDetails
            {
                id = 106,
                Name = "Ayisha",
                Gender = "Female",
                Salary = 670000
            });
            return li;
        }




        public List<EmployeeDetails> getDetails(int id)
        {
            List<EmployeeDetails> li1 = new List<EmployeeDetails>();
            Program p = new Program();
            var li = p.AllUsers();
            foreach (var x in li)
            {
                if (x.id == id)
                {
                    li1.Add(x);
                }
            }
            return li1;
        }
        static void Main(string[] args) { }
    }
}
