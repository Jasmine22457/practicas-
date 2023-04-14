using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    public class ClsCategoria
    {
        public string Nombre { get; set; }
        public ClsArea Area { get; set; }

        public ClsCategoria(string name, ClsArea area)
        {
            Nombre = name;
            Area = area;
        }
    }

}
