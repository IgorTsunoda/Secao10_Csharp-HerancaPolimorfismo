using System;
using System.Globalization;
namespace DesafioMetodosAbstratos.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        public Person()
        {
        }
        public Person(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }
        public abstract double TaxToPay();
        public virtual string TaxesPaid()
        {
            return Name
                + " : $ "
                + TaxToPay().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
