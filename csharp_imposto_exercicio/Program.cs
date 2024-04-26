using csharp_imposto_exercicio.Entities;
using System.Globalization;

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

List<Person> persons = new List<Person>(); 

for (int i = 1; i<=n; i++)
{
    Console.Write("Individual or company (i/c): ");
    char personType = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    switch (personType)
    {
        case 'i':
            Console.Write("Health expenditures: ");
            double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            persons.Add(new PhysicalPerson(name, income, healthExpenditures));
            break;
        case 'c':
            Console.Write("Number of employees: ");
            int employeesNumber = int.Parse(Console.ReadLine());
            persons.Add(new JuridicalPerson(name, income, employeesNumber));
            break;
    }
}

Console.WriteLine("\nTaxes paid: ");
double taxesSum = 0;
foreach (Person person in persons)
{
    taxesSum += person.Taxes();
    Console.WriteLine($"{person.Name}: {person.Taxes().ToString("F2", CultureInfo.InvariantCulture)}R$");
}

Console.WriteLine($"TOTAL TAXES: {taxesSum.ToString("F2", CultureInfo.InvariantCulture)}R$");