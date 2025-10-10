 public class PagamentoPayPal : IPagamento
    {
        public string EmailUtente { get; set; }

        public PagamentoPayPal(string emailUtente)
        {
            EmailUtente = emailUtente;
        }
        public void EseguiPagamento(decimal importo)
        {
            Console.WriteLine($"Pagamento di €{importo} tramite PayPal da: {EmailUtente}");
        }

        public void MostraMetodo()
        {
            Console.WriteLine("Metodo: PayPal");
        }
    }