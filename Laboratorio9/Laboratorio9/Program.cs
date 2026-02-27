using System;


    class Program
    {
        static void Main(string[] args)
        {

            double precio;
            string formaDePago;
            string numeroDeCuenta = "";

            do
            {
                Console.Write("Ingrese el precio del producto (valor positivo): ");
            } while (!double.TryParse(Console.ReadLine(), out precio) || precio <= 0);

            do
            {
                Console.Write("Ingrese la forma de pago (efectivo o tarjeta): ");
                formaDePago = Console.ReadLine().ToLower(); 
            } while (formaDePago != "efectivo" && formaDePago != "tarjeta");

            if (formaDePago == "tarjeta")
            {
                bool esNumeroValido;
                do
                {
                    Console.Write("Ingrese el número de cuenta (16 dígitos): ");
                    numeroDeCuenta = Console.ReadLine();

                    esNumeroValido = numeroDeCuenta.Length == 16 && long.TryParse(numeroDeCuenta, out _);

                    if (!esNumeroValido)
                    {
                        Console.WriteLine("Error: El número de cuenta debe contener exactamente 16 dígitos numéricos.");
                    }
                } while (!esNumeroValido);
            }

            
            Console.WriteLine("\n--- Resumen de la Compra ---");
            Console.WriteLine($"Precio del producto: ${precio:F2}");
            Console.WriteLine($"Forma de pago: {formaDePago}");
            if (formaDePago == "tarjeta")
            {
              
                Console.WriteLine($"Número de cuenta: **** **** **** {numeroDeCuenta.Substring(12)}");
            }
            Console.WriteLine("\nOperación finalizada.");
        }
    }
