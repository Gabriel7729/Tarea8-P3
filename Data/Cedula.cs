using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea8_P3.Data
{
    public class Cedula
    {
        public string ID { get; set; }
    }

    public class Results
    {
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public bool ok { get; set; }
        public string foto { get; set; }
    }
}
