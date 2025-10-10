using GestioneBiblioteca;

public class Libro : Prodotto
{
        public string Autore { get; set; }
        public int Pagine { get; private set; }

        public Libro(string titolo, int anno, double prezzo, string autore, int pagine)
            : base(titolo, anno, prezzo)
        {
            Autore = autore;
            Pagine = pagine;
        }

        //  Override del metodo astratto
        public override void MostraDettagli()
        {
            Console.WriteLine($"\n📚 LIBRO");
            Console.WriteLine($"   Titolo: {Titolo}");
            Console.WriteLine($"   Autore: {Autore}");
            Console.WriteLine($"   Anno di pubblicazione: {AnnoPublicazione}");
            Console.WriteLine($"   Pagine: {Pagine}");
            Console.WriteLine($"   Prezzo: €{Prezzo:F2}");
        }

        //  Override del metodo virtuale
        public override string GetTipo()
        {
            return "Libro";
        }
      
}