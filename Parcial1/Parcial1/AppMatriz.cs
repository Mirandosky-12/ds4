using System;

namespace Parcial1
{
    class AppMatriz
    {
        private Matriz miMatriz;

        public void Ejecutar()
        {
            Console.WriteLine("Diego Lopez, Parcial I ");
            int dimension = PedirDimension();

            miMatriz = new Matriz(dimension);

            miMatriz.GenerarPatron();

            Console.WriteLine("\nMatriz generada:");
            miMatriz.Imprimir();

            long producto = miMatriz.CalcularProducto();
            Console.WriteLine("\nEl resultado de la multiplicación de los valores centrales es: " + producto);

        }

        private int PedirDimension()
        {
            int n;
            while (true)
            {
                Console.Write("Introduce la dimensión N: ");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n >= 3 && n % 2 != 0)
                    {
                        return n;
                    }
                    else
                    {
                        Console.WriteLine("Error: El número debe ser impar y mayor o igual a 3.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Debe ingresar un número entero válido.");
                }
            }
        }
    }
}