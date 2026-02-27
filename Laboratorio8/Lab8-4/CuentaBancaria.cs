using System;

public class CuentaBancaria
{
    private decimal saldo;
    public decimal Saldo
    {
        get { return saldo; }
        set
        {
            if (value >= 0)
                saldo = value;
            else
                throw new ArgumentException("El daldo no puede ser negativo.");
        }
    }
}