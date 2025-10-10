namespace GestioneBiblioteca;
class Program
{
    static Biblioteca biblioteca = new Biblioteca();
    static void Main(string[] args)
    {
         bool continua = true;

        while (continua)
        {
            MostraMenu();
            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    InserisciLibro();
                    break;
                case "2":
                    biblioteca.MostraTuttiProdotti();
                    break;
                case "0":
                    continua = false;
                    Console.WriteLine("\n Arrivederci!");
                    break;
                default:
                    Console.WriteLine("\n Scelta non valida!");
                    break;
            }

            if (continua)
            {
                Console.WriteLine("\nPremi INVIO per continuare...");
                Console.ReadLine();
            }
        }
             static void MostraMenu()
        {
            Console.Clear();
            Console.WriteLine("---GESTIONE BIBLIOTECA---");
   
            Console.WriteLine("\n1. Inserisci Libro");
            Console.WriteLine("2.  Mostra tutti i prodotti");
            Console.WriteLine("0.  Esci");
            Console.Write("\n Scegli un'opzione: ");
        }

        static void InserisciLibro()
        {
            try
            {
                Console.Write("\nTitolo: ");
                string titolo = Console.ReadLine();

                Console.Write("Autore: ");
                string autore = Console.ReadLine();

                Console.Write("Anno: ");
                int anno = int.Parse(Console.ReadLine());

                Console.Write("Numero pagine: ");
                int pagine = int.Parse(Console.ReadLine());

                Console.Write("Prezzo (€): ");
                double prezzo = double.Parse(Console.ReadLine());

                // POLIMORFISMO - Oggetto di tipo Libro assegnato a variabile di tipo Prodotto
                Prodotto libro = new Libro(titolo, anno, prezzo, autore, pagine);
                biblioteca.AggiungiProdotto(libro);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n Errore: {ex.Message}");
            }
        }
        }
    }
