using System.Net.Http.Headers;

public class Array
{
    private int[] arrayNumeri;
    private int[] ArrayNumeri
    {
        get
        {
            return arrayNumeri;
        }
        set
        {
            arrayNumeri = value;
        }
    }

    private void operazioniArray()
    {
        Console.WriteLine("Inserisci la dimensione dell'array:");
        int dim = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        int somma = 0;
        int media = 0;
        int pos = 0;
        ArrayNumeri = new int[dim];

        for (int i = 0; i < dim; i++)
        {
            Console.WriteLine($"Inserisci numero in posizione {i}:\n");
            ArrayNumeri[i] = int.Parse(Console.ReadLine());
           
            somma += ArrayNumeri[i];
            Console.WriteLine("***** NUMERO AGGIUNTO *****\n\n");
            pos++;
        }
        media = somma / pos;
        Console.WriteLine($"La somma di tutti i numeri è {somma}\n");
        Console.WriteLine($"La media di tutti i numeri è {media}\n");

    }




    public static void Main(string[] args)
    {
        Array array = new Array();
        array.operazioniArray();
        
    }
}