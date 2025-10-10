public class Computer : Dispositivo
{

    public string SistemaOperativo { get; set; }
    public int MemoriaRAM { get; set; } //GB

    public Computer(string modello, string sistemaOperativo, int memoriaRAM)
        : base(modello)
    {
        SistemaOperativo = sistemaOperativo;
        MemoriaRAM = memoriaRAM;
    }
    public override void Accendi()
    {
        Console.WriteLine($"{Modello} si sta accendendo...");
    }
    public override void Spegni()
    {
        Console.WriteLine($"{Modello} si sta spegnendo...");
    }
    public override void MostraInfo()
    {
        base.MostraInfo();
        Console.WriteLine($"Sistema Operativo: {SistemaOperativo}");
        Console.WriteLine($"Memoria RAM: {MemoriaRAM} GB");
    }
}