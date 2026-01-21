using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNetPracticaDepartamentos.Models
{
    public class Empleado
    {
        public int Emp_no { get; set; }
        public string Apellido { get; set; }
        public string Oficio { get; set; }
        public int Salario { get; set; }
    }
}
