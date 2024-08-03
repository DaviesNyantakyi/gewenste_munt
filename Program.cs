using System;


namespace GewensteMunt
{
    class Program
    {
        static void Main()
        {
            string naamwisselkoers;
            decimal bedrag, wisselkoers, resultaat;

            Console.WriteLine("Gelieve de volgende gegevens in te geven:");

            Console.Write("\t- Naam van de gewenste munt: ");
            naamwisselkoers = Console.ReadLine();
            Console.Write("\t- Wisselkoers  van de gewenste munt: ");
            wisselkoers = decimal.Parse(Console.ReadLine());
            Console.Write("\t- Om te zetten bedrag: ");
            bedrag = decimal.Parse(Console.ReadLine());

            resultaat = bedrag * wisselkoers;

            Console.WriteLine($"Het bedrag in de gewenste munt is: {resultaat} {naamwisselkoers}");
        }
    }
}