using System;
    class Program
    {
        static void Main(string[] args)
        {

            double ladoA, ladoB, ladoC;

            
            ladoA = PedirLado("A");
            ladoB = PedirLado("B");
            ladoC = PedirLado("C");

            
            if ((ladoA + ladoB > ladoC) && (ladoA + ladoC > ladoB) && (ladoB + ladoC > ladoA))
            {
                
                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("\nEl triángulo es EQUILÁTERO.");
                }
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("\nEl triángulo es ISÓSCELES.");
                }
                else
                {
                    Console.WriteLine("\nEl triángulo es ESCALENO.");
                }
            }
            else
            {
                Console.WriteLine("\nLas medidas ingresadas NO forman un triángulo válido.");
            }
        }

        static double PedirLado(string nombreLado)
        {
            double lado;
            do
            {
                Console.Write($"Ingrese la longitud del lado {nombreLado} (valor positivo): ");
            } while (!double.TryParse(Console.ReadLine(), out lado) || lado <= 0);
            return lado;
        }
    }