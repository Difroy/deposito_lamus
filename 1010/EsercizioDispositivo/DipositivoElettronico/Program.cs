

class Program
{
    static void Main(string[] args)
    {

        List<Dispositivo> dispositivi = new List<Dispositivo>();

      
                dispositivi.Add(new Computer("HP PC", "Windows 11 Pro", 32)); 
               dispositivi.Add(new Stampante("HP Pro", 1200, false));

        Console.WriteLine("LABORATORIO TECNICO - DISPOSITIVI ");
        

        foreach (var dispositivo in dispositivi)
        {
            Console.WriteLine(new string('-', 45));

        
            dispositivo.MostraInfo();

           
            dispositivo.Accendi();

       
            dispositivo.Spegni();

            Console.WriteLine();
        }

        Console.WriteLine(new string('=', 45));
        Console.WriteLine("\n Tutti i dispositivi sono stati gestiti tramite POLIMORFISMO!");
        Console.WriteLine("\nPremi INVIO per uscire...");
        Console.ReadLine();
    }

}