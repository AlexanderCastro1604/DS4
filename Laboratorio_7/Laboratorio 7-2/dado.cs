using System;

class Dado
{
    private int valor;
    private static Random aleatorio = new Random();

    public Dado()
    {
        valor = 1; 
    }

    public void Tirar()
    {
        valor = aleatorio.Next(1, 7); 
    }

    public void Imprimir()
    {
        Console.WriteLine("El valor del dado es: " + valor);
    }

    public int RetornarValor()
    {
        return valor;
    }
}
