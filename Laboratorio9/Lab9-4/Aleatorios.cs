using System;
    public class Aleatorios
    {
        private readonly Random _random;
        public Aleatorios()
        {
            _random = new Random();
        }
        public int GenerarNumero(int min, int max)
        {
            if (min > max)
            {
                int temp = min;
                min = max;
                max = temp;
            }
            return _random.Next(min, max + 1);
        }
        public int[] GenerarArreglo(int cantidad, int min, int max)
        {
            if (cantidad <= 0) return new int[0];

            int[] arreglo = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                arreglo[i] = GenerarNumero(min, max);
            }
            return arreglo;
        }
    }
