namespace EmployeeOOP.Classes
{
    public class HourlyEmployee : Employee
    {
        #region Properties

        public int Hours { get; set; }
        public decimal HoursValue { get; set; }


        #endregion

        #region Methods 

        public HourlyEmployee()
        {

        }
        public override decimal GetValueToPay()
        {
            return HoursValue * Hours;
        }


        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Horas: {Hours}" +
                $"Valor por Hora: {HoursValue}";
        }

        #endregion

    }
}
