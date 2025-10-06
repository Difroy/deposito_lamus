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
        //int contatoreOrdini = 0;
        List<(string Gusto, int Quantita, double Prezzo)> dettagliOrdine = new List<(string, int, double)>();



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

             dettagliOrdine.Add((
                Gusto: gusti[indiceGusto], 
                Quantita: quantita, 
                Prezzo: prezzi[indiceGusto]
            ));

            double prezzoGusto = CalcolaTotale(indiceGusto, quantita, prezzi);
            totale += prezzoGusto;
            totalePalline += quantita;
            //contatoreOrdini = +1;
        }
        if (totalePalline > 0)
        {
            Console.WriteLine("\n===== RIEPILOGO ORDINE =====");
            Console.WriteLine("--- Dettagli: ---");
            foreach (var dettaglio in dettagliOrdine)
            {
                double costoRiga = dettaglio.Quantita * dettaglio.Prezzo;
                Console.WriteLine($"- {dettaglio.Quantita}x {dettaglio.Gusto} (€{dettaglio.Prezzo:F2}/cad.) - Costo: €{costoRiga:F2}");
            }
            Console.WriteLine("-----------------");
            Console.WriteLine($"Totale palline: {totalePalline}");
            Console.WriteLine($"Subtotale: €{totale:F2}");

            if (totale > 10)
            {
                double sconto = totale * 0.10;
                double totaleFinale = totale - sconto;
                Console.WriteLine($"Sconto (10%): -€{sconto:F2}");
                Console.WriteLine($"TOTALE FINALE: €{totaleFinale:F2}");
            }
            else
            {
                Console.WriteLine($"TOTALE FINALE: €{totale:F2}");
            }

            Console.WriteLine("\nGrazie per il tuo acquisto! Arrivederci!");
        }
        else
        {
            Console.WriteLine("\nNessun ordine effettuato. Arrivederci!");
        }
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



