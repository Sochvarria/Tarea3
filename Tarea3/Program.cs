using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== MENÚ PRINCIPAL =====");
        Console.WriteLine("1. Aprobación de un curso");
        Console.WriteLine("2. Precio de una compra");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            // CASO 1: APROBACIÓN DE UN CURSO

            Console.Write("Ingrese la nota final: ");

            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                if (nota >= 0 && nota <= 100)
                {
                    if (nota >= 70)
                    {
                        Console.WriteLine("El estudiante aprobó.");
                    }
                    else
                    {
                        Console.WriteLine("El estudiante reprobó.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: la nota debe estar entre 0 y 100.");
                }
            }
            else
            {
                Console.WriteLine("Error: debe ingresar un número válido.");
            }
        }
        else if (opcion == 2)
        {
            // CASO 2: PRECIO DE UNA COMPRA

            Console.Write("Ingrese el precio del producto: ");

            if (double.TryParse(Console.ReadLine(), out double precio) && precio > 0)
            {
                Console.Write("Ingrese la cantidad: ");

                if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)
                {
                    double total = precio * cantidad;
                    double descuento = 0;

                    if (total > 25000)
                    {
                        descuento = total * 0.10;
                    }

                    double totalPagar = total - descuento;

                    Console.WriteLine("\n===== RESUMEN DE COMPRA =====");
                    Console.WriteLine("Total: ₡" + total);
                    Console.WriteLine("Descuento: ₡" + descuento);
                    Console.WriteLine("Total a pagar: ₡" + totalPagar);
                }
                else
                {
                    Console.WriteLine("Error: la cantidad debe ser un número entero mayor que 0.");
                }
            }
            else
            {
                Console.WriteLine("Error: el precio debe ser un número mayor que 0.");
            }
        }
        else
        {
            Console.WriteLine("Error: opción no válida.");
        }
    }
}