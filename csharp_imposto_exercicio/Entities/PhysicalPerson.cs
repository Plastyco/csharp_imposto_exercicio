namespace csharp_imposto_exercicio.Entities
{
    public class PhysicalPerson : Person
    {
        public double HealthExpenditures { get; set; }

        public PhysicalPerson()
        {
        }

        public PhysicalPerson(string name, double income, double healthExpenditures) : base(name, income)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            double tax;
            double porcent = Income < 20000.00 ? 0.15 : 0.25;

            tax = (Income * porcent) - (HealthExpenditures * 0.5);

            return tax;
        }
    }
}
