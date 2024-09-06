using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion4.clases
{
    internal class RRHH
    {
        public RRHH() { }

        public double CalcularSalario(Empleado empleado, double deducciones)
        {
            return empleado.Salary - deducciones;
        }
        //Aumentar el salario en un %x si su salario base es menor a x salario
        public void AumentarSalario(Empleado empleado, double porcentaje, double techo)
        {
            empleado.Salary = (empleado.Salary <= techo)? empleado.Salary = (empleado.Salary * (1+porcentaje)): empleado.Salary;
        }
    }
}
