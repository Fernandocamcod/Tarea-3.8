using System;

class ProgramaDescuento
{
    static void Main()
    {
        const double precioPorUnidad = 100.00; // Precio por unidad del producto
        int cantidad;
        double precioFinal;

        Console.WriteLine("Ingrese la cantidad de unidades del producto:");

        // Intentar leer la cantidad ingresada y manejar posibles errores
        if (int.TryParse(Console.ReadLine(), out cantidad) && cantidad > 0)
        {
            // Determinar el descuento aplicable
            double descuento;

            switch (cantidad)
            {
                case int n when (n >= 1 && n <= 10):
                    descuento = 0; // Sin descuento
                    break;
                case int n when (n >= 11 && n <= 20):
                    descuento = 0.10; // 10% de descuento
                    break;
                case int n when (n >= 21 && n <= 50):
                    descuento = 0.15; // 15% de descuento
                    break;
                case int n when (n > 50):
                    descuento = 0.20; // 20% de descuento
                    break;
                default:
                    descuento = 0; // Sin descuento
                    break;
            }

            // Calcular el precio final
            precioFinal = cantidad * precioPorUnidad * (1 - descuento);

            // Mostrar el resultado
            Console.WriteLine($"Cantidad de unidades: {cantidad}");
            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
            Console.WriteLine($"Precio final: ${precioFinal:F2}");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo para la cantidad.");
        }

        // Esperar a que el usuario presione una tecla antes de cerrar
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}
