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
        int totalePalline = 0;


        while (true)
        {
            StampaMenu(gusti, prezzi);

            Console.Write("\nInserisci lìindice del gusto (0-4) o -1 per terminare: ");
            int indiceGusto = int.Parse(Console.ReadLine());

            if (indiceGusto == -1)
            {
                break;
            }
            if (indiceGusto < 0 || indiceGusto >= gusti.Length)
            {
                Console.WriteLine("Indice non valido. Riprova \n");
                continue;
            }
            Console.Write("Inserisci la quantità di palline: ");
            int quantita = int.Parse(Console.ReadLine());
            if (quantita <= 0)
            {
                Console.WriteLine("Errore: La quantità deve essere positiva! Riprova.\n");
                continue;
            }

            double prezzoGusto = CalcolaTotale(indiceGusto, quantita, prezzi);
            totale += prezzoGusto;
            totalePalline += quantita;

            Console.WriteLine($"\nAggiunto: {quantita}x {gusti[indiceGusto]} = €{prezzoGusto:F2}\n");

        }
        
    
        static void StampaMenu(string[] gusti, double[] prezzi)
        {
            Console.WriteLine("\n===== MENU GELATERIA =====");
            for (int i = 0; i < gusti.Length; i++)
            {
                Console.WriteLine($"[{i}] {gusti[i]} - €{prezzi[i]:F2} a pallina");
            }
        }

        static double CalcolaTotale(int gusto, int quantita, double[] prezzi)
        {
            return prezzi[gusto] * quantita;
        }



    }



}