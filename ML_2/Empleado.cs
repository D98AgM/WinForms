using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML_2
{
    public class Empleado
    {

        public int IdEmpleado { get; set; }

        public string Nombre { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public string RFC { get; set; }

        public decimal Sueldo { get; set; }

        public List<object> Empleados;


    }
}
