using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero positivo:");
        int numero = int.Parse(Console.ReadLine());

        if (numero <= 1)
        {
            Console.WriteLine("El número debe ser mayor que 1.");
        }
        else
        {
            bool esPrimo = true;
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
            if (esPrimo)
            {
                Console.WriteLine("{0} es un número primo.", numero);
            }
            else
            {
                Console.WriteLine("{0} no es un número primo.", numero);
            }
        }

        Console.ReadKey();
    }
}