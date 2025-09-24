using System;

class PruebaVector1
{
    private int[] sueldos; 

    public void Cargar()
    {
        sueldos = new int[5]; 

        for (int f = 0; f < 5; f++)
        {
            Console.Write("Ingrese sueldo del operario " + (f + 1) + ": ");
            string linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea); 
        }
    }

    public void Imprimir()
    {
        Console.WriteLine("\nLos 5 sueldos de los operarios son:");
        for (int f = 0; f < 5; f++)
        {
            Console.Write("[" + sueldos[f] + "] ");
        }
        Console.WriteLine(); 
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        PruebaVector1 pv = new PruebaVector1();
        pv.Cargar();
        pv.Imprimir();
    }
}

