using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_17_06
{
    internal class Atleta
    {
        public string nome;
        public string cognome;
        public string sport;

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

        public string Sport
        {
            get
            {
                return sport;
            }
            set
            {
                sport = value;
            }
        }

        public void stampaAtleta()
        {
            Console.WriteLine(Nome);
            Console.WriteLine(Cognome);
            Console.WriteLine(Sport);
            Console.WriteLine("L'atleta si chiama:" + nome + " " +  cognome + " e pratica come sport: " + sport);
        }
    }

}
