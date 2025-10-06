//using System;

using System.Security.Cryptography.X509Certificates;

class Program
{
  static void Main(string[] args)
  {

    //Esercizio 1.
    /* int n1 = 10;
    int n2 = 20;
    int totale = n1 + n2;

    Console.WriteLine("1 prova: - Addizione: n1 + n2 = " + (n1 + n2));
    Console.WriteLine($"2 prova: - Addizione: n1 + n2 = {n1 + n2}");
    Console.WriteLine($"3 prova: - Addizione: n1 + n2 = {totale}"); */


    //Esercizio 2
    /*  Console.Write("Inserisci prezzo: ");
       double prezzoOriginale = double.Parse(Console.ReadLine());
      Console.Write("Inserisci sconto (%): ");
      double percentualeSconto = double.Parse(Console.ReadLine());

      double importoSconto = prezzoOriginale * (percentualeSconto / 100);
      double importoTotale = prezzoOriginale - importoSconto;
      Console.WriteLine($"Prezzo finale: {importoTotale}€"); */

    //Esercizio 3

    /* Console.Write("Inserisci un numero: ");
    float numero = float.Parse(Console.ReadLine());
    bool isPositivo = numero > 0;

    Console.WriteLine($"Il numero è positivo? {isPositivo}"); */

    //Esercizio 4
    /* Console.Write("Esercizio 4 - Digita un numero intero: ");
    int primoNumero = int.Parse(Console.ReadLine());
    Console.Write("Digita un numero con la virgola: ");
    double secondoNumero = double.Parse(Console.ReadLine());
    double somma = primoNumero + secondoNumero;
    Console.WriteLine($"La somma è: {somma}"); */


    //Esercizio 5
    /* 
           Console.Write("Inserisci la tua età: ");
           int eta = int.Parse(Console.ReadLine());
           Console.Write("Inserisci la tua altezza in metri: ");
           float altezza = float.Parse(Console.ReadLine());
           Console.WriteLine($"La somma è: {eta + altezza}"); */

    //Esercizio 6
    /* const int etaMaggiorenne = 18;

    Console.Write("Inserisci la tua età: ");
    int eta = int.Parse(Console.ReadLine());

    string risultato = eta >= etaMaggiorenne ? "maggiorenne" : "minorenne";
    Console.WriteLine($"Sei {risultato}"); */


    //Esercizio 7


    /*  const double limite = 100.0;
     const double sconto = 0.10;
     Console.Write("Inserisci il prezzo del prodotto: ");
     double prezzo = double.Parse(Console.ReadLine());
     double prezzoFinale = prezzo > limite ? prezzo * (1 - sconto) : prezzo;
     Console.WriteLine($"Il prezzo finale è: {prezzoFinale}€"); */

    //Esercizio 8
    /*   const double limite2 = 60.0;

      Console.Write("Inserisci il primo numero: ");
      int num1 = int.Parse(Console.ReadLine());

      Console.Write("Inserisci il secondo numero: ");
      int num2 = int.Parse(Console.ReadLine());

      Console.Write("Inserisci il terzo numero: ");
      int num3 = int.Parse(Console.ReadLine());
      double media = (num1 + num2 + num3) / 3.0;
      if (media >= limite2)
      {
        Console.WriteLine("Hai superato la prova");
      }
      else
      {
        Console.WriteLine("Prova fallita.");
      }
      Console.WriteLine($"La media è: {media}"); */

    //Esercizio 9

    /*   Console.Write("Inserisci un numero intero: ");
      int numero = int.Parse(Console.ReadLine());
      Console.WriteLine(numero % 2 == 0 ? $"{numero} è pari" : $"{numero} è dispari"); */


    //Esercizio 10
    /*  const string passwordCorretta = "12345";

     Console.Write("Inserisci la password numerica: ");
     string passwordInserita = Console.ReadLine();

     if (passwordInserita == passwordCorretta)
     {
       Console.WriteLine("Accesso consentito");
     }
     else
     {
       Console.WriteLine("Accesso negato");
     }
  */





    //Esercizio 11
    /* Console.Write("Inserisci il primo numero: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Inserisci il secondo numero: ");
    double num2 = double.Parse(Console.ReadLine());

    Console.Write("Inserisci l'operatore (+ oppure -): ");
    string operatore = Console.ReadLine();

    double risultato;

    if (operatore == "+")
    {
      risultato = num1 + num2;
      Console.WriteLine($"Risultato: {num1} + {num2} = {risultato}");
    }
    else if (operatore == "-")
    {
      risultato = num1 - num2;
      Console.WriteLine($"Risultato: {num1} - {num2} = {risultato}");
    }
    else
    {
      Console.WriteLine("Operatore non valido!");
    }
 */

    //Esercizio 12

   /*  Console.Write("Inserisci un numero intero: ");
       int numero = int.Parse(Console.ReadLine());

       Console.WriteLine($"\nTabellina del {numero}:");

       for (int i = 1; i <= 10; i++)
       {
           int risultato = numero * i;
           Console.WriteLine($"{numero} x {i} = {risultato}");
       } */

    //Esercizio 13

 /*    Console.Write("Quanti numeri vuoi inserire? ");
    int quantita = int.Parse(Console.ReadLine());

    int somma = 0;

    for (int i = 1; i <= quantita; i++)
    {
      Console.Write($"Inserisci il numero {i}: ");
      int numero = int.Parse(Console.ReadLine());
      somma += numero;
    }

    double media = (double)somma / quantita;

    Console.WriteLine($"\nLa media dei numeri inseriti è: {media}"); */


//Esercizio 14

    /* Console.Write("Inserisci un numero intero positivo: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero < 0)
    {
        Console.WriteLine("Errore: Il numero deve essere positivo!");
    }
    else
    {
        long fattoriale = 1;

        for (int i = 1; i <= numero; i++)
        {
            fattoriale *= i;
        }

        Console.WriteLine($"Il fattoriale di {numero} è: {fattoriale}");
    } */


    //Esercizio 15
       /*  Console.WriteLine("Ciao, scrivi una frase...");
        string frase = Console.ReadLine();
        int contatoreCaratteri = 0;
        foreach (char carattere in frase)
        {
          contatoreCaratteri++;
        }
        Console.WriteLine($"Numero di cifre: {contatoreCaratteri}"); */
    

    //Esercizio 16
    
       /*  Console.WriteLine("Inserisci una frase...");
        string frase = Console.ReadLine();
        string fraseSenzaSpazi = "";

        foreach (char c in frase)
        {
          if (c != ' ')
          {
            fraseSenzaSpazi += c;
          }
        }
        Console.WriteLine($"{fraseSenzaSpazi}"); */
    

    //Esercizio 17

    /* static int ContaVocali(string testo)
    {
      string vocali = "aeiou";
      int contatore = 0;

      foreach (char carattere in testo)
      {
        char carattereVocale = char.ToLower(carattere);

        if (vocali.Contains(carattereVocale))
        {
          contatore++;
        }
      }

      return contatore;
    }

    Console.Write("Inserisci una frase: ");
    string frase = Console.ReadLine();

    int numeroVocali = ContaVocali(frase);
    Console.WriteLine($"Numero di vocali: {numeroVocali}"); */


  }

  //

}