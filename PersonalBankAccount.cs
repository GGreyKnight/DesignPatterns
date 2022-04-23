using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class PersonalBankAccount : BankAccount
    {
        public override void MakeWithdrawal(float amount)
        {
            Console.WriteLine("Personal bank account withdrawl");
            if (amount < 0)
            {
                throw new Exception("Amount must be positive number");
            }

            if(balance - amount < 0)
            {
                throw new Exception("Personal bank account cannot go in debt");
            }

            balance -= amount;
        }
    }
}
