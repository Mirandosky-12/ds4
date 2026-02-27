using System;

abstract class ClaseAbstracta
{
    //se fuerza la herencia de la clase para definir estos metodos
    abstract protected string tomarValor();
    abstract public string prefixValor(string prefix);
    //metodo comun
    public void printOut()
    {
        Console.WriteLine(tomarValor());
    }
}