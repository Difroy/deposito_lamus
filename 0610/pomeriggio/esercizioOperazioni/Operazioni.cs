public class Operazioni
{

    int a;
    int b;
    int risultato;



    public int Somma(int a, int b)
    {
        return a + b;
    
    }
    public int Moltiplicazione(int a, int b)
    {
        return a * b;
    }
public void StampaRisultato(string operazione, int risultato)
    {
        Console.WriteLine($"Il risultato dell'operazione {operazione} è: {risultato}");
    }


}