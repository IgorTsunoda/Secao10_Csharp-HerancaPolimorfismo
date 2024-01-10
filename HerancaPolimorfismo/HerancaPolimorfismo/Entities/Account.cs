using System;
using System.Drawing;

namespace HerancaPolimorfismo.Entities
{
     class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
    }
}
