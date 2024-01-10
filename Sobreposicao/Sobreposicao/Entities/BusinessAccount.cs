using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Sobreposicao.Entities
{
   class BusinessAccount : Account
    {
        public double InterestRate { get; set; }

        public BusinessAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    
        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
