using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public abstract class Employee
    {
        #region Fields
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Date? BirthDate { get; set; }
        public Date? HiringDate { get; set; }
        public bool? IsActive { get; set; }
        #endregion

        #region Methods
        public Employee()
        {
            
        }
        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"INFORMACIÓN EMPLEADO \n\t " +
                $"ID: {Id}\n\t" +
                $"Nombre: {FirstName}\n\t" +
                $"Apellido: {LastName}\n\t" +
                $"Fecha de cumpleaños: {BirthDate}\n\t" +
                $"Fecha de contratación: {HiringDate}\n\t" +
                $"¿Empleado activo?: {IsActive}\n\t";
        }
        #endregion
    }
}
