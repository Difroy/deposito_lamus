using System;
using System.Collections.Generic;
using System.Linq;

namespace GestioneBiblioteca
{

    public abstract class Prodotto
    {

        private string titolo;
        private string annoPubblicazione;
        private double prezzo;


        public Prodotto(string titolo, int annoPubblicazione, double prezzo)
        {
            Titolo = titolo;
            AnnoPublicazione = annoPubblicazione;
            Prezzo = prezzo;
        }
        public string Titolo
        {
            get { return titolo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Il titolo non può essere vuoto.");
                    titolo = value;
                }

            }
        }

        public int AnnoPublicazione
        {
            get { return int.Parse(annoPubblicazione); }
            set
            {
                if (value < 1000 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("L'anno di pubblicazione deve essere un numero positivo.");
                }
                annoPubblicazione = value.ToString();
            }
        }

        public double Prezzo
        {
            get { return prezzo; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Il prezzo non può essere negativo");
                prezzo = value;
            }
        }

        public abstract void MostraDettagli();

        public virtual string GetTipo()
        {
            return "Prodotto generico";
        }
        public string GetInfo()
        {
            return $"{Titolo} ({annoPubblicazione}) - €{Prezzo:F2}";
        }
    }




}