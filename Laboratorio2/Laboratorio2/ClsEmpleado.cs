using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    public class ClsEmpleado
    {
        public string Nombre { get; set; }
        public string Passw { get; set; }

        public ClsEmpleado(string nombre, string passw)
        {
            Nombre = nombre;
            Passw = passw;
        }
    }
}
