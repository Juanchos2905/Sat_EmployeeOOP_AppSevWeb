using EmployeeOOP.Classes;

try
{
    //Declaración de variables
    int day, month, year, worker, hours;
    string firstName, lastName;
    decimal salary, commisionPercentaje, sales, hoursValue, baase;

    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese 1 si desea ingresar un empleado asalariado");
    Console.WriteLine("Ingrese 2 si desea ingresar un empleado pagado por comision");
    Console.WriteLine("Ingrese 3 si desea ingresar un empleado pagado por horas");
    Console.WriteLine("Ingrese 4 si desea ingresar un empleado pagado por comision + base");
    worker = Convert.ToInt32(Console.ReadLine());


    //Inicialización de la clase Date
    Date dateObject = new Date(day, month, year);

    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

    Console.WriteLine("Ingresar el nombre completo: ");
    firstName = Console.ReadLine();

    Console.WriteLine("Ingresar apellidos: ");
    lastName = Console.ReadLine();

    if (worker == 1)
    {

        Console.WriteLine("Ingresar salario devengado: ");
        salary = Decimal.Parse(Console.ReadLine());

        SalaryEmployee SalaryEmployee = new SalaryEmployee()
        {
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
    else if(worker == 2)
    {

        Console.WriteLine("Ingrese la comision de las ventas: ");
        commisionPercentaje = Decimal.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el total de las ventas: ");
        sales = Decimal.Parse(Console.ReadLine());

        CommissionEmployee CommissionEmployee = new CommissionEmployee()
        {
            Id = 123456,
            FirstName = firstName,
            LastName = lastName,
            BirthDate = dateObject,
            HiringDate = dateObject,
            IsActive = true,
            CommisionPercentaje = commisionPercentaje,
            Sales = sales
        };
    }
    else if(worker ==3)
    {
        Console.Write("Ingresar las horas trabajadas: ");
        hours = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el valor por hora: ");
        hoursValue = Decimal.Parse(Console.ReadLine());

        HourlyEmployee hourlyEmployee = new HourlyEmployee()
        {
            Id = 123456,
            FirstName = firstName,
            LastName = lastName,
            BirthDate = dateObject,
            HiringDate = dateObject,
            IsActive = true,
            Hours = hours,
            HoursValue = hoursValue
        };
    }
    else if (worker ==4)
    {
        Console.WriteLine("Ingrese la comision de las ventas: ");
        commisionPercentaje = Decimal.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el total de las ventas: ");
        sales = Decimal.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de la base: ");
        baase = Decimal.Parse(Console.ReadLine());

        BaseCommissionEmployee baseCommissionEmployee = new BaseCommissionEmployee()
        {
            Id = 123456,
            FirstName = firstName,
            LastName = lastName,
            BirthDate = dateObject,
            HiringDate = dateObject,
            IsActive = true,
            CommisionPercentaje = commisionPercentaje,
            Sales = sales,
            Base = baase
            
        };
    }
    else 
    {
        Console.WriteLine("Ingrese un empleado existente.");
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}