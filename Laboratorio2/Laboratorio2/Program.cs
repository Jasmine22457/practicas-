using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<ClsArea> area = new List<ClsArea>();
            List<ClsCategoria> categoria = new List<ClsCategoria>();
            List<ClsProducto> producto = new List<ClsProducto>();

            area.Add(new ClsArea("*---Alimentos---*"));
            area.Add(new ClsArea("*---Belleza---*"));
            area.Add(new ClsArea("*---Cuidado del hogar---*"));

            categoria.Add(new ClsCategoria("*---verduras---*", area[0]));
            categoria.Add(new ClsCategoria("*---Maquillaje--*", area[1]));
            categoria.Add(new ClsCategoria("*---Limpieza---*", area[2]));

            Console.WriteLine("*--------Bienvenido al supermercado--------*");


            ClsEmpleado empleado = new ClsEmpleado("user", "1234");

            bool loginCorrecto = false;

            do
            {
                Console.WriteLine("Por favor, ingrese sus credenciales: ");

                Console.Write("Username: ");
                string name = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                if (empleado.Nombre == name && empleado.Passw == password)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Bienvenido Empleado, actualmente se encuentra activo");
                    Console.ForegroundColor = ConsoleColor.White;
                    loginCorrecto = true;
                }
                else
                {
                    Console.WriteLine("Crendenciales incorrectas, intentelo nuevamente!");
                }
            } while (!loginCorrecto);




            while (true)
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Crear área");
                Console.WriteLine("2. Crear categoría");
                Console.WriteLine("3. Crear producto");
                Console.WriteLine("4. Registrar venta");
                Console.WriteLine("5. Salir");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("*---Ingrese el nombre del área:---*");
                        string areaNombre = Console.ReadLine();
                        area.Add(new ClsArea(areaNombre));
                        Console.WriteLine("*---Área creada con éxito---*");
                        break;
                    case 2:
                        Console.WriteLine("*---Ingrese el nombre de la categoría:---*");
                        string categoriaNombre = Console.ReadLine();
                        Console.WriteLine("*---Seleccione el área a la que pertenece la categoría:---*");
                        for (int i = 0; i < area.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {area[i].Nombre}");
                        }
                        int areaOption = int.Parse(Console.ReadLine());
                        ClsCategoria categoria1 = new ClsCategoria(categoriaNombre, area[areaOption - 1]);
                        categoria.Add(categoria1);
                        Console.WriteLine("*---Categoría creada con éxito.---*");
                        break;
                    case 3:
                        Console.WriteLine("*---Ingrese el nombre del producto:---*");
                        string productoNombre = Console.ReadLine();
                        Console.WriteLine("*---Ingrese el nombre del proveedor:---*");
                        string proveedorNombre = Console.ReadLine();
                        Console.WriteLine("*---Ingrese la fecha de caducidad (dd/mm/yyyy):---*");
                        DateTime fechaExpiracion = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        Console.WriteLine("*---Ingrese la fecha de entrada (dd/mm/yyyy):---*");
                        DateTime fechaEntrada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        Console.WriteLine("*--Ingrese el detalle del producto:--*");
                        string detalles = Console.ReadLine();
                        Console.WriteLine("*---Ingrese el precio del producto:--*");
                        double precio = double.Parse(Console.ReadLine());
                        Console.WriteLine("*--Ingrese la cantidad de unidades del producto:--*");
                        int cantidad = int.Parse(Console.ReadLine());
                        Console.WriteLine("*--Seleccione la categoría a la que pertenece el producto:--*");
                        for (int i = 0; i < categoria.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {categoria[i].Nombre} ({categoria[i].Area.Nombre})");
                        }
                        int categoryOption = int.Parse(Console.ReadLine());
                        ClsProducto producto1 = new ClsProducto(productoNombre, proveedorNombre, fechaExpiracion, fechaEntrada, detalles, precio, cantidad, categoria[categoryOption - 1]);
                        producto.Add(producto1);
                        Console.WriteLine("*--Producto creado con éxito.--*");
                        break;
                    case 4:
                        Console.WriteLine("*--Ingrese nombre de cliente--*");
                        string userNombre = Console.ReadLine();
                        List<ClsProducto> selectedProducts = new List<ClsProducto>();
                        while (true)
                        {
                            Console.WriteLine("*--Seleccione un producto para agregar a la venta:--*");
                            for (int i = 0; i < producto.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {producto[i].Nombre} ({producto[i].Categoria.Nombre} - {producto[i].Categoria.Area.Nombre})");
                            }
                            Console.WriteLine("0. Terminar selección de productos");
                            option = int.Parse(Console.ReadLine());
                            if (option == 0)
                            {
                                break;
                            }
                            else if (option > 0 && option <= producto.Count)
                            {
                                selectedProducts.Add(producto[option - 1]);
                            }
                            else
                            {
                                Console.WriteLine("*--Opción inválida. Intente de nuevo.--*");
                            }
                        }
                        double total = 0;
                        Console.WriteLine("*--Productos seleccionados:--*");
                        foreach (ClsProducto p in selectedProducts)
                        {
                            Console.WriteLine($"{p.Nombre} - {p.Precio}");
                            total += p.Precio;
                        }
                        Console.WriteLine($"Total: {total}");
                        Console.WriteLine($"Venta registrada por {userNombre}.");
                        break;
                    case 5:
                        Console.WriteLine("*--Gracias por utilizar la aplicación del supermercado.--*");
                        return;
                    default:
                        Console.WriteLine("*--Opción inválida. Intente de nuevo.--*");
                        break;
                }



            }

        }
    }
}
