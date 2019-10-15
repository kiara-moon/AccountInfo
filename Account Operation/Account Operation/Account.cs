using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Operation
{
    class Account
    {
        public string AccountNumber;
        public string CustomerName;
        public double balance;

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;

            }

        }
        public void Withdrow(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
        }
        public string GetReport()
        {
            string massage = CustomerName + ", " + "your account Namber: " + AccountNumber + "," + "and it's balance: " + balance + "taka";
            return massage;
        }
    
}
}
