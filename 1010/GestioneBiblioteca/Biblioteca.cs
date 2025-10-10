namespace GestioneBiblioteca
{
    public class Biblioteca
    {
        
        private List<Prodotto> catalogo;

        public Biblioteca()
        {
            catalogo = new List<Prodotto>();
        }

       
        public void AggiungiProdotto(Prodotto prodotto)
        {
            catalogo.Add(prodotto);
            Console.WriteLine($"\n✓ {prodotto.GetTipo()} aggiunto al catalogo!");
        }

        public void MostraTuttiProdotti()
        {
            if (catalogo.Count == 0)
            {
                Console.WriteLine("\n Catalogo vuoto!");
                return;
            }

            Console.WriteLine("\n" + new string('=', 50));
            Console.WriteLine("CATALOGO BIBLIOTECA");
            Console.WriteLine(new string('=', 50));

            foreach (var prodotto in catalogo)
            {
                prodotto.MostraDettagli();
            }
        }
    }
}