public class Program
{

    static void Main(string[] args)
    {


        Operazioni op = new Operazioni();

        Console.WriteLine("Inserisci il primo numero: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il secondo numero: ");
        int num2 = int.Parse(Console.ReadLine());

        int somma = op.Somma(num1, num2);
        op.StampaRisultato("Somma", somma);
        int prodotto = op.Moltiplicazione(num1, num2);
        op.StampaRisultato("Prodotto", prodotto);


    }



}



