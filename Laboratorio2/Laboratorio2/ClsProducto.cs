using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    public class ClsProducto
    {
        public string Nombre { get; set; }
        public string Proveedor { get; set; }
        public DateTime Fechadeexpiracion { get; set; }
        public DateTime Fechadeentrada { get; set; }
        public string Detalles { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public ClsCategoria Categoria { get; set; }

        public ClsProducto(string nombre, string proveedor, DateTime fechadeexpiracio, DateTime fechadeentrada, string detalles, double precio, int cantidad,ClsCategoria categoria)
        {
            Nombre = nombre;
            Proveedor = proveedor;
            Fechadeexpiracion = fechadeexpiracio;
            Fechadeentrada = fechadeentrada;
            Detalles = detalles;
            Precio = precio;
            Cantidad = cantidad;
            Categoria = categoria;
        }
    }

}
