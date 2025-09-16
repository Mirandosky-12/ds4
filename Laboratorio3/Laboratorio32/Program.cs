using System;

public class CalculosMatematicos
{
    public int Calcular(int a, int b)
    {
        
        return (a + b) * (a - b);
    }

    public double CalcularArea(double r)
    {
        const double PI = 3.14;
        return PI*Math.Pow(r, 2);
    }

    public int CalcularPerimetro(int largo, int ancho)
    {
        return 2*(largo+ancho);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        int primerNumero, segundoNumero;

        Console.WriteLine("Introduce el primer numero: ");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el segundo numero: ");
        segundoNumero = Convert.ToInt32(Console.ReadLine());

        CalculosMatematicos calc = new CalculosMatematicos();

        int resultado = calc.Calcular(primerNumero, segundoNumero);
        double resultadoArea = calc.CalcularArea(primerNumero);
        int resultadoPerimetro = calc.CalcularPerimetro(primerNumero, segundoNumero);

        Console.WriteLine("El resultado de la ecuación (a+b)*(a-b) es: " + resultado);
        Console.WriteLine("El resultado del área del círculo es: " + resultadoArea);
        Console.WriteLine("El resultado del perímetro del rectángulo es: " + resultadoPerimetro);
    }
}


