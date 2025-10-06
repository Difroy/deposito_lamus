public class Persona
{

    public string Nome;
    public string Cognome;
    public int AnnoNascita;
    public int Eta;


    public Persona(string nome, string cognome, int annoNascita)
    {
        Nome = nome;
        Cognome = cognome;
        AnnoNascita = annoNascita;
    }

    public void Saluta()
    {
        Console.WriteLine($"Ciao mi chiamo {Nome}");
    }

    public void CalcoloEta(int AnnoNascita)
    {
        const int AnnoCorrente = 2025;
        AnnoNascita = this.AnnoNascita;
        Eta = (AnnoCorrente - AnnoNascita);
  
    }
    public void Presentazione()
    {
        Console.WriteLine($"{Nome} {Cognome} è nato nel {AnnoNascita} e ha {Eta} anni");
    }


}