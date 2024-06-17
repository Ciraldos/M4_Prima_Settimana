using Esercizio_17_06;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    public static void Main(string[] args)
    {
        Animale animal = new Animale();
        Atleta atleta = new Atleta();
        Veicolo car = new Veicolo();
        Dipendente worker = new Dipendente();

        animal.nome = "leone";
        animal.razza= "felino";

        atleta.nome = "Amelie";
        atleta.cognome = "Lens";
        atleta.Sport = "DJ";

        car.marca = "Fiat";
        car.modello = "500";
        car.anno = 1999;

        worker.nome = "Ilario";
        worker.cognome = "Alicante";
        worker.Eta = 33;




        animal.stampaAnimale();
        atleta.stampaAtleta();
        car.stampaVettura();
        worker.stampaDipendente();
    }

}
