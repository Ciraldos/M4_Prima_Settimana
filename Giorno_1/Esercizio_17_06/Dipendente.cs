using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Esercizio_17_06
{
    internal class Dipendente
    {
        public string nome;
        public string cognome;
        public decimal eta;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public string Cognome
        {
            get
            {
                return cognome;
            }
            set
            {
                cognome = value;
            }
        }
        public decimal Eta
        {
            get
            {
                return eta;
            }
            set
            {
                eta = value;
            }
        }

        public void stampaDipendente()
        {
            Console.WriteLine(nome);
            Console.WriteLine(cognome);
            Console.WriteLine(eta);
            Console.WriteLine("Il dipendente si chiama: " + nome + " " + cognome + " di anni: " + eta);


        }
    }
}
