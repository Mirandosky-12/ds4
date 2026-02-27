using System;
    class Program
    {
        static void Main(string[] args)
        {

           
            Aleatorios generador = new Aleatorios();

            int min = 1;
            int max = 10;

            
            int numeroGenerado = generador.GenerarNumero(min, max);
            Console.WriteLine($"\n1. Número aleatorio generado entre {min} y {max}: {numeroGenerado}");

  
            int cantidad = 7;
            int[] arregloGenerado = generador.GenerarArreglo(cantidad, min, max);
            Console.WriteLine($"\n2. Arreglo con {cantidad} números aleatorios (pueden repetirse):");
            Console.WriteLine($"[{string.Join(", ", arregloGenerado)}]");
        }
    }
