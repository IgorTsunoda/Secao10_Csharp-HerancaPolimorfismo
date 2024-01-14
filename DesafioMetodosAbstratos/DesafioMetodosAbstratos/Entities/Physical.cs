using System;

namespace DesafioMetodosAbstratos.Entities
{
    class Physical : Person
    {
        public double HealthExpenses { get; set; }
        public Physical()
        {
        }
        public Physical(string name, double anualIncome, double healthExpenses) : base(name, anualIncome)
        {
            HealthExpenses = healthExpenses;
        }
        public override double TaxToPay()
        {
            if (HealthExpenses > 0)
            {
                return (AnualIncome * 0.25) - (HealthExpenses * 0.50);
            }
            else
            {
                return AnualIncome;
            }
        }
    }
}
