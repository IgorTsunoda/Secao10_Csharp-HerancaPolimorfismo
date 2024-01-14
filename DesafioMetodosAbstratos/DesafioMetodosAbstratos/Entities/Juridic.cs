using System;

namespace DesafioMetodosAbstratos.Entities
{
    class Juridic : Person
    {
        public int QtdEmployess { get; set; }
        public Juridic()
        {
        }
        public Juridic(string name, double anualIncome, int qtdEmployess) : base(name, anualIncome)
        {
            QtdEmployess = qtdEmployess;
        }
        public override double TaxToPay()
        {
            if (QtdEmployess < 10)
            {
                return AnualIncome = (AnualIncome/100) * 16;
            }
            else
            {
                return AnualIncome = (AnualIncome/100) * 14;
            }
        }
    }
}