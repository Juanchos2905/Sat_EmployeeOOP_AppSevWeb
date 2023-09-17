namespace EmployeeOOP.Classes
{
    public class CommissionEmployee : Employee
    {
        #region Properties
        public decimal CommisionPercentaje { get; set; }
        public decimal Sales { get; set; }
        #endregion

        #region Methods
        public CommissionEmployee()
        {

        }
        public override decimal GetValueToPay()
        {
            return CommisionPercentaje * Sales;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Porcentaje de comisión: {CommisionPercentaje}" +
                $"Valor total de ventas: {Sales:C2}";
        }
        #endregion


    }
}
