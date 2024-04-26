namespace csharp_imposto_exercicio.Entities
{
    public abstract class Person
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public Person()
        {
        }

        public Person(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double Taxes();
    }
}
