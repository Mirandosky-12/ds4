using System;

class Trabajador : Persona
{
    //Campo de cada objeto Trabajador que almacena cuanto gana
    public int Sueldo;

    public Trabajador(string nombre, int edad, string nif, int sueldo) : base(nombre, edad, nif)
    {
        //Inicializamos cada Trabajador en base al construcctor de Persona
        Sueldo = sueldo;
    }
}