using EmployeeOOP.Classes;

try
{
    //Declaración de variables
    int day, month, year;
    string firstName, lastName;
    decimal salary;

    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización de la clase Date
    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

    Console.WriteLine("Ingresar el nombre completo: ");
    firstName = Console.ReadLine();

    Console.WriteLine("Ingresar apellidos: ");
    lastName = Console.ReadLine();

    Console.WriteLine("Ingresar salario devengado: ");
    salary = Decimal.Parse(Console.ReadLine());


    SalaryEmployee SalaryEmployee = new SalaryEmployee() {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = salary
    };


    Console.WriteLine(SalaryEmployee);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}