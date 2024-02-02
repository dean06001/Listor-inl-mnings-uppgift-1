using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> namnLista = new List<string>();

        while (true)
        {
            Console.Write("Ange ett namn (Tryck enter för att sluta):");
            string namn = Console.ReadLine();

            if (namn == null || namn == "")
            {
                break;
            }
            else
            {
                namnLista.Add(namn);
            }
        }

        Console.WriteLine("Nedan är namnen du angav i omvänd ordning:");
        namnLista.Sort();
        namnLista.Reverse();
        foreach (string namn in namnLista)
        {
            Console.WriteLine(namn);
        }
        Console.ReadLine();
    }
}
