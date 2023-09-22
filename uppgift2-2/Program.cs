using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wow, hur långt hoppade du där Elin?");
        string elinhopplängd = Console.ReadLine();
        Console.WriteLine("okej, du då Alma?");
        string almahopplängd = Console.ReadLine();
        int elin = int.Parse(elinhopplängd);
        int alma = int.Parse(almahopplängd);
        int resultat = elin - alma;
        Console.WriteLine("Okej, så Elin hoppade " + resultat + " meter längre");

    }
}