
public class Stampante : Dispositivo
{
    public int Risoluzione { get; set; } //DPI
    public bool Colore { get; set; }

    public Stampante(string modello, int risoluzione, bool colore)
        : base(modello)
    {
        Risoluzione = risoluzione;
        Colore = colore;
    }
    public override void Accendi()
    {
        Console.WriteLine($"{Modello} si sta accendendo...");
    }
    public override void Spegni()
    {
        Console.WriteLine($"{Modello} va in standby.");
    }
    public override void MostraInfo()
    {
        base.MostraInfo();
        Console.WriteLine($"Risoluzione: {Risoluzione} DPI");
        Console.WriteLine($"Stampa a colori: {(Colore ? "Sì" : "No")}");
    }
}