using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class CompanyBankAccount : BankAccount
    {
        public override void MakeWithdrawal(float amount)
        {
            Console.WriteLine("Make withdrawl for company bank account");
            if(amount < 0)
            {
                throw new Exception("Amount must be positive number");
            }

            balance -= amount;
        }
    }
}
