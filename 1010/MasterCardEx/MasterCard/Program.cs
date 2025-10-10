class Program
{
    static void Main(string[] args)
    {
        List<IPagamento> pagamenti = new List<IPagamento>();
        pagamenti.Add(new PagamentoCarta("Visa"));
        pagamenti.Add(new PagamentoCarta("Mastercard"));
        pagamenti.Add(new PagamentoContanti());
        pagamenti.Add(new PagamentoPayPal("mario.rossi@email.com"));

        Console.WriteLine("SISTEMA GESTIONE PAGAMENTI");
    
        foreach (var pagamento in pagamenti)
        {
            Console.WriteLine(new string('-', 50));

            pagamento.MostraMetodo();

            pagamento.EseguiPagamento(50.00m);

            Console.WriteLine();
        }
        Console.WriteLine(new string('=', 50));
        Console.WriteLine("\nPremere INVIO per uscire...");
        Console.ReadLine();
    }
}
