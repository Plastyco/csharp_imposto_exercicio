namespace csharp_imposto_exercicio.Entities
{
    public class JuridicalPerson : Person
    {
        public int EmployeesNumber { get; set; }

        public JuridicalPerson()
        {
        }

        public JuridicalPerson(string name, double income, int employeesNumber) : base(name, income)
        {
            EmployeesNumber = employeesNumber;
        }

        public override double Taxes()
        {
            double tax;
            double porcent = EmployeesNumber < 10 ? 0.16 : 0.14;
            tax = Income * porcent;
            return tax;
        }
    }
}
