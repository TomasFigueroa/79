using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> frasesHashSet = new HashSet<string>();
        SortedSet<string> frasesSortedSet = new SortedSet<string>();

        while (true)
        {
            Console.Write("Introduce una frase (o deja vacío para salir): ");
            string frase = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(frase))
                break;

            if (frasesHashSet.Contains(frase))
            {
                Console.WriteLine("Esta frase ya fue introducida anteriormente.");
            }
            else
            {
                frasesHashSet.Add(frase);
                frasesSortedSet.Add(frase);
                Console.WriteLine("Frase agregada al conjunto.");
            }
        }

        Console.WriteLine("\nFrases introducidas en orden alfabético:");
        foreach (string frase in frasesSortedSet)
        {
            Console.WriteLine(frase);
        }
    }
}
