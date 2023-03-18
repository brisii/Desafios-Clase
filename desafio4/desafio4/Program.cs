using System;

class Pared
{
    public double Alto { get; set; }
    public double Largo { get; set; }
    public double SuperficieFrontal { get { return Alto * Largo; } }
}

class Program
{
    static void Main(string[] args)
    {
        Pared pared = new Pared();
        pared.Alto = 3.5;
        pared.Largo = 5.2;

        Console.WriteLine("La superficie frontal es {0:0.00}.", pared.SuperficieFrontal);

        Console.ReadKey();
    }
}
