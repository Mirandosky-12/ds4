using System;

namespace Parcial1
{
    class Matriz
    {
        private int[,] matriz;
        private int dimension;
        private Random aleatorio;

        public Matriz(int n)
        {
            dimension = n;
            matriz = new int[dimension, dimension];
            aleatorio = new Random(); 
        }

        public void GenerarPatron()
        {
            int centro = dimension / 2;
            for (int f = 0; f < dimension; f++) 
            {
                for (int c = 0; c < dimension; c++)
                {
                    if ((f == centro && Math.Abs(c - centro) <= 1) || (c == centro && Math.Abs(f - centro) <= 1))
                    {
                        matriz[f, c] = aleatorio.Next(1, 101);
                    }
                    else
                    {
                        matriz[f, c] = 0;
                    }
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < dimension; f++)
            {
                for (int c = 0; c < dimension; c++)
                {
                    Console.Write(matriz[f, c] + "\t");
                }
                Console.WriteLine();
            }
        }

        public long CalcularProducto()
        {
            long producto = 1;
            foreach (int valor in matriz)
            {
                if (valor != 0)
                {
                    producto = producto * valor;
                }
            }
            return producto;
        }
    }
}