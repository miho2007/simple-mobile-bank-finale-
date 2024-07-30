
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace mobileBank
{
    internal class User
    {
        public int ID { get; set; }
        public int Salary { get; set; }
        public string UserName { get; set; }
        public UserType UserType { get; set; }

        public User(int iD, int salary, string userName, UserType userType)
        {
            ID = iD;
            Salary = salary;
            UserName = userName;
            UserType = userType;
        }

        public void TransferMoney(int recipientId, int amount)
        {

        }

        public void SeeMymoney()
        {
            Console.WriteLine($"Your current balance is: {Salary}");
        }
    }
}


