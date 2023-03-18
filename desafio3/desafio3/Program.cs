using System;

class Program
{
    static void Main(string[] args)
    {
        int contador = 0;
        int suma = 0;
        int puntaje;

        while (true)
        {
            Console.WriteLine("Ingrese un puntaje (1-10) o escriba 'fin' para terminar:");
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "fin")
            {
                break;
            }

            if (!int.TryParse(entrada, out puntaje) || puntaje < 1 || puntaje > 10)
            {
                Console.WriteLine("Entrada inválida. Ingrese un número entre 1 y 10 o escriba 'fin' para terminar.");
                continue;
            }
