using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaZapatos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Zapatos zapato = new Zapatos();

            int opc;


            while (true)
            {
                Console.WriteLine("----------***Bienvenido a la zapateria en linea***--------------\n");
                Console.WriteLine("Selecione una tienda \n");
                Console.WriteLine("Menu");
                Console.WriteLine("1-Zapateria Md");
                Console.WriteLine("2-Zapateria Jose");
                Console.WriteLine("3-Zapateria Andrea ");
                Console.WriteLine("4-Salir");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine("-------**Zapateria Md**-------");
                        Menu menuMd = new Menu();

                        menuMd.Estilo();
                        zapato.estilo = Console.ReadLine();

                        menuMd.Marca();
                        zapato.marca = Console.ReadLine();

                        menuMd.Talla();
                        zapato.talla = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("precio:");
                        double p1 = Convert.ToDouble(Console.ReadLine());
                        double desc = 0.05;

                        zapato.precio = p1 - (p1 * desc);

                        Console.WriteLine("\n-------**recibo**-------");
                        Console.WriteLine("Estilo: " + zapato.Estilo);
                        Console.WriteLine("Marca: " + zapato.Marca);
                        Console.WriteLine("Sise: " + zapato.talla);
                        Console.WriteLine("Descuento: " + desc);
                        Console.WriteLine("Precio: $" + zapato.precio);
                        break;
                    case 2:
                        Console.WriteLine("-------**Zapateria Jose**-------");
                        Menu menuj = new Menu();

                        menuj.Estilo();
                        zapato.estilo = Console.ReadLine();

                        menuj.Marca();
                        zapato.marca = Console.ReadLine();

                        menuj.Talla();
                        zapato.talla = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("precio:");
                        double p2 = Convert.ToDouble(Console.ReadLine());
                        double desc2 = 0.10;

                        zapato.precio = p2 - (p2 * desc2);

                        Console.WriteLine("\n-------**Recibo**-------");
                        Console.WriteLine("Estilo: " + zapato.Estilo);
                        Console.WriteLine("Marca: " + zapato.Marca);
                        Console.WriteLine("Sise: " + zapato.talla);
                        Console.WriteLine("Descuento: " + desc2);
                        Console.WriteLine("Precio: $" + zapato.precio);
                        break;

                    case 3:
                        Console.WriteLine("-------**Zapateria Andrea**-------");
                        Menu menuA = new Menu();

                        menuA.Estilo();
                        zapato.estilo = Console.ReadLine();

                        menuA.Marca();
                        zapato.marca = Console.ReadLine();

                        menuA.Talla();
                        zapato.talla = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite el precio:");
                        double p3 = Convert.ToDouble(Console.ReadLine());
                        double desc3 = 0.15;

                        zapato.precio = p3 - (p3 * desc3);

                        Console.WriteLine("\n-------factura-------");
                        Console.WriteLine("Estilo: " + zapato.Estilo);
                        Console.WriteLine("Marca: " + zapato.Marca);
                        Console.WriteLine("Sise: " + zapato.talla);
                        Console.WriteLine("Descuento: " + desc3);
                        Console.WriteLine("Precio: $" + zapato.precio);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("La opcion no esta definida");
                        break;
                }
            }




        }

    }
}

class Menu
{
    public void Estilo()
    {
        Console.WriteLine("Estilos");
        Console.WriteLine("1-Sport");
        Console.WriteLine("2-Casual");
        Console.WriteLine("3-Botas");
    }
    public void Marca()
    {
        Console.WriteLine("Marcas");
        Console.WriteLine("1-Nike");
        Console.WriteLine("2-Converse");
        Console.WriteLine("3-DrMartin");
    }
    public void Talla()
    {
        Console.WriteLine("Size");
        Console.WriteLine("1-35");
        Console.WriteLine("2-37");
        Console.WriteLine("3-39");
    }
}
