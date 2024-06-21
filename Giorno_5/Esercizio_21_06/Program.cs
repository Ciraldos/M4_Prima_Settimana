using System.Globalization;

namespace Esercizio_21_06
{
    internal class Contribuente
    {

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string DataNascita { get; set; }

        public string CodiceFiscale {get; set;}

        public enum Sesso
        {
            Maschio,
            Femmina
        }
        public string ComuneResidenza { get; set; }
        
        public double RedditoAnnuale { get; set; }

        private void Start()
        {
            Console.WriteLine("+++++++ MENU +++++++");
            Console.WriteLine("Opzione 1: Calcola imposta da versare");
            Console.WriteLine("Opzione 2: Esci");

            int x = int.Parse(Console.ReadLine());
  
                if (x == 1)
                {
                    Console.WriteLine("HAI SCELTO: Calcola imposta da versare ");
                    calcolaImposta();
                }
                else if (x == 2)
                {
                    {
                        Console.WriteLine("HAI SCELTO: Esci ");
                        esci();
                    }
                }
                else
                {
                    Console.WriteLine("\nOpzione non valida\n");
                }
        }

        private void calcolaImposta()
        {
            Contribuente c = new Contribuente();

            Console.WriteLine("\nInserisci Nome:");
            c.Nome = Console.ReadLine();

            Console.WriteLine("\nInserisci Cognome:");
            c.Cognome = Console.ReadLine();

            Console.WriteLine("\nInserisci Data di nascita:");
            c.DataNascita = Console.ReadLine();

            Console.WriteLine("\nInserisci Codice Fiscale:");
            c.CodiceFiscale = Console.ReadLine();

            Console.WriteLine("\nInserisci Sesso:");
            Sesso sesso;
            while (!Enum.TryParse(Console.ReadLine(), true, out sesso))
            {
                Console.WriteLine("Input non valido. Inserisci 'Maschio' o 'Femmina':");
            }

            Console.WriteLine("\nInserisci Comune di residenza:");
            c.ComuneResidenza = Console.ReadLine();

            Console.WriteLine("\nInserisci Reddito Annuale:");
            double redditoAnnuale;
            while (!double.TryParse(Console.ReadLine(), out redditoAnnuale))
            {
                Console.WriteLine("Inserisci un valore numerico per il reddito annuale:");
            }
            c.RedditoAnnuale = redditoAnnuale;



            double imposta = 0;

            if (c.RedditoAnnuale < 15000)
            {
                imposta = (c.RedditoAnnuale / 100) * 23;
            }
            else if (c.RedditoAnnuale <= 28000)
            {
                imposta = 3450 + ((c.RedditoAnnuale - 15000) / 100) * 27;
            }
            else if (c.RedditoAnnuale <= 55000)
            {
                imposta = 6960 + ((c.RedditoAnnuale - 28000) / 100) * 38;
            }
            else if (c.RedditoAnnuale <= 75000)
            {
                imposta = 17220 + ((c.RedditoAnnuale - 55000) / 100) * 41;
            }
            else
            {
                imposta = 25420 + ((c.RedditoAnnuale - 75000) / 100) * 43;
            }

            Console.WriteLine("\n\n++++++ CALCOLO IMPOSTA ++++++\n");
            Console.WriteLine($"\n--- CONTRIBUENTE: {c.Nome} {c.Cognome}\n");
            Console.WriteLine($"\n--- RESIDENTE IN: {c.ComuneResidenza}\n");
            Console.WriteLine($"\n--- CODICE FISCALE: {c.CodiceFiscale}\n");
            Console.WriteLine($"\n--- REDDITO DICHIARATO: {c.RedditoAnnuale} euro\n");
            Console.WriteLine($"\n--- IMPOSTA DA VERSARE: {imposta} euro\n");




        }
        private void esci() { }



        static void Main(string[] args)
        {
            Contribuente c = new Contribuente();
            c.Start();
        }
    }
}
