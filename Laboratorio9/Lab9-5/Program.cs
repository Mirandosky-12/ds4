using System;

namespace Laboratorio95
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Problema 5: Generar Arreglo Sin Repetir ---");

 
            Aleatorios generador = new Aleatorios();

            
            int cantidad = 10;
            int min = 1;
            int max = 15;

            Console.WriteLine($"\nGenerando {cantidad} números únicos entre {min} y {max}...");

            
            int rangoTotal = max - min + 1;
            if (cantidad > rangoTotal)
            {
                Console.WriteLine($"Error: Imposible generar {cantidad} números únicos, solo hay {rangoTotal} disponibles.");
                return; 
            }

            
            List<int> numerosUnicos = new List<int>();
            while (numerosUnicos.Count < cantidad)
            {
                
                int numeroNuevo = generador.GenerarNumero(min, max);

                if (!numerosUnicos.Contains(numeroNuevo))
                {
                    numerosUnicos.Add(numeroNuevo);
                }
            }

            
            Console.WriteLine("\nArreglo de números no repetidos generado:");
            Console.WriteLine($"[{string.Join(", ", numerosUnicos)}]");
        }
    }
}
