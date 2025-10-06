using System.Runtime.CompilerServices;

class DolceGelo
{

    static void Main(String[] args)
    {
        Console.Write("Benvenuto alla Gelateria DolceGelo! Vuoi acquistare un gelato? (Si/No): ");
        string risposta = Console.ReadLine().ToLower();

        if (risposta != "si" && risposta != "sì")
        {
            Console.WriteLine("Grazie per la visita! Arrivederci!");
            return;
        }

        //Array gusti
        string[] gusti = { "Cioccolato", "Vaniglia", "Fragola", "Pistacchio", "Limone" };

        double[] prezzi = { 2.50, 3, 2, 4, 1.50 };

        double totale = 0;
        int numeroPalline = 0;


      static void StampaMenu(string[] gusti, double[] prezzi)
    {
        Console.WriteLine("\n===== MENU GELATERIA =====");
        for (int i = 0; i < gusti.Length; i++)
        {
            Console.WriteLine($"[{i}] {gusti[i]} - €{prezzi[i]:F2} a pallina");
        }
    }   




}



}