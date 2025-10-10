public class PagamentoContanti : IPagamento
{
    public void EseguiPagamento(decimal importo)
    {
        Console.WriteLine($"Pagamento di €{importo} in contanti");
    }

    public void MostraMetodo()
    {
        Console.WriteLine("Metodo: Contanti");
    }
}