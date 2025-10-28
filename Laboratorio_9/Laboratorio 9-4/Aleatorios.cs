using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Aleatorios
{
    private Random random;

    public Aleatorios()
    {
        random = new Random();
    }

    public int GenerarEntre2Numeros(int min, int max)
    {
        return random.Next(min, max + 1);
    }

    public int[] GenerarArregloAleatorio(int cantidad, int min, int max)
    {
        int[] arreglo = new int[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            arreglo[i] = random.Next(min, max + 1);
        }

        return arreglo;
    }

    
    public int[] GenerarArregloSinRepetidos(int cantidad, int min, int max)
    {
        
        if (cantidad > (max - min + 1))
        {
            throw new ArgumentException("No es posible generar tantos números únicos en el rango dado");
        }

        HashSet<int> numerosUnicos = new HashSet<int>();

        while (numerosUnicos.Count < cantidad)
        {
            int numero = random.Next(min, max + 1);
            numerosUnicos.Add(numero);
        }

        return numerosUnicos.ToArray();
    }
}
