using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_17_06
{
    internal class Animale
    {
        public string nome;
        public string razza;

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
        public string Razza
        {
            get
            {
                return razza;
            }
            set
            {
                razza = value;
            }
        }
        public void stampaAnimale()
        {
            Console.WriteLine(nome);
            Console.WriteLine(razza);
            Console.WriteLine("L'animale è un: " + nome + " di razza: " + razza);

        }
    }
}
