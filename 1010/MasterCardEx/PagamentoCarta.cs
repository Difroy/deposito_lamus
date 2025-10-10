public class PagamentoCarta : IPagamento
    {
        public string Circuito { get; set; } 

        public PagamentoCarta(string circuito)
        {
            Circuito = circuito;
        }

        public void EseguiPagamento(decimal importo)
        {
            Console.WriteLine($"Pagamento di €{importo} con carta (Circuito: {Circuito})");
        }

        public void MostraMetodo()
        {
            Console.WriteLine("Metodo: Carta di credito");
        }
    }