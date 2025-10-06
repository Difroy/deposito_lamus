public class Persona
{

    public string Nome;
    public int Eta;

    public Persona(String nome, int eta)
    {
        Nome = nome;
        Eta = eta;
    }

    public void Saluta()
    {
        Console.WriteLine($"Ciao mi chiamo {Nome} e ho {Eta} eta");
    }


}