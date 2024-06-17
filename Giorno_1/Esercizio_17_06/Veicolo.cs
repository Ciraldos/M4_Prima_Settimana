using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_17_06
{
    internal class Veicolo
    {
        public string marca;
        public string modello;
        public decimal anno;

        public string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                marca = value;
            }
        }
        public string Modello
        {
            get {
                return modello; 
                    }
            set
            {
                modello = value;
            }
        }
        public decimal Anno
        {
            get
            {
                return anno;
            }
            set
            {
                anno = value;
            }
        }

        public void stampaVettura()
        {
            Console.WriteLine(marca);
            Console.WriteLine(modello);
            Console.WriteLine(anno);
            Console.WriteLine("L'autovettura è una: " + marca + " modello: " + modello + " anno: " + anno);

        }
    }
}
