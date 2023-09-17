using EmployeeOOP.Classes;

try
{
    //Declaración de variables
    int day, month, year, sales;
    string firstName, lastName;
    decimal salary, commisionPercentaje;

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
    CommissionEmployee commissionEmployee = new CommissionEmployee();
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

    Console.WriteLine("Ingresar el nombre completo: ");
    firstName = Console.ReadLine();

    Console.WriteLine("Ingresar apellidos: ");
    lastName = Console.ReadLine();

    Console.WriteLine("Ingrese número de ventas realizadas: ");
    sales = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese la comisión que le pagan por venta: ");
    commisionPercentaje = Decimal.Parse(Console.ReadLine());

    salary = commisionPercentaje * sales;


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