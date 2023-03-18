using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ingrese el  número entero positivo:");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("los números pares hasta {0} son:", numero);
        for (int i = 1; i <= numero; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadKey();
    }
}