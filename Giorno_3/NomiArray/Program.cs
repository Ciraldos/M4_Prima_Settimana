public class Array
{
    private string[] arrayNomi;
    private string[] ArrayNomi {
        get { 
            return arrayNomi; 
        }
        set {
            arrayNomi = value;
        } 
    }

    private void caricaArray()
    {
        Console.WriteLine("Inserisci la dimensione dell'array:");
        int dim = int.Parse(Console.ReadLine());
        ArrayNomi = new string[dim];
        
        for (int i = 0; i < dim; i++)
        {
            Console.WriteLine("Inserisci Nome:");
            ArrayNomi[i] = Console.ReadLine();
            Console.WriteLine("Nome Aggiunto\n");
        }
    }

    private void cercaNome()
    {
        Console.WriteLine("Inserisci il nome da cercare:");
        string nome = Console.ReadLine();
        for (int i = 0; i < ArrayNomi.Length; i++)
        {
            if (nome == ArrayNomi[i])
                Console.WriteLine($"Nome trovato in posizione {i+1}: {nome}");
        }
        
        
    }

    


    public static void Main(string[] args)
    {   
        Array array = new Array();
        array.caricaArray();
        for (int i = 0; i < array.arrayNomi.Length; i++)
        {
            Console.WriteLine($"Nome in posizione {i}: {array.arrayNomi[i]}");
        }
        array.cercaNome();
    } 
}