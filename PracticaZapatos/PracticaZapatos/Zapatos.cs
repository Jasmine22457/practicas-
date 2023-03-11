using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaZapatos
{
    internal class Zapatos
    {

        public string estilo;
        public string marca;
        public double talla;
        public double precio;

        public string Estilo
        {
            set { estilo = value; }
            get
            {

                switch (estilo)
                {
                    case "1":
                        this.estilo = "Sport";
                        break;

                    case "2":
                        this.estilo = "Casual";
                        break;

                    case "3":
                        this.estilo = "Botas";
                        break;

                    default:
                        this.estilo = "Estilo de Zapato no seleccionado";
                        break;
                    case null:
                        this.estilo += "No ha ingresado ningun estilo de  zapatos";
                        break;

                }
                return this.estilo;
            }
        }

        public string Marca
        {
            set { marca = value; }
            get
            {

                switch (marca)
                {
                    case "1":
                        this.marca = "Nike";
                        break;

                    case "2":
                        this.marca = "Converse";
                        break;

                    case "3":
                        this.marca = "DrMartin";
                        break;

                    default:
                        this.marca = "La marca de Zapato no se a seleccionado";
                        break;
                    case null:
                        this.marca += "No ha ingresado ninguna marca de zapato";
                        break;

                }
                return this.marca;
            }
        }

        public double Talla
        {
            set { talla = value; }
            get
            {

                switch (talla)
                {
                    case 1:
                        this.talla = 36;
                        break;

                    case 2:
                        this.talla = 37;
                        break;

                    case 3:
                        this.talla = 38;
                        break;

                    default:
                        this.talla = 0;
                        break;
                }
                return this.talla;
            }
        }
    }
}
