
public class ContoCorrente
{
   public string Name { get; set; }
   public string LastName { get; set; }

   private decimal saldo = 0; 
   public decimal Saldo { 
        get { return saldo; }
        set { saldo = value; } 
    }
   
    private bool contoAperto = false;
    public bool ContoAperto { 
        get { return contoAperto; } 
        set { contoAperto = value; } 
    }
    
   private void Start()
    {
        Console.WriteLine("Seleziona un opzione:\n");
        Console.WriteLine("Opzione 1: CREA CONTO CORRENTE\n");
        Console.WriteLine("Opzione 2: EFFETTUA PRELIEVO\n");
        Console.WriteLine("Opzione 3: EFFETTUA DEPOSITO\n");
        Console.WriteLine("Opzione 4: ESCI\n");



        int scelta = int.Parse(Console.ReadLine());
        switch (scelta) {
            case 1:
                Console.WriteLine("Hai scelto: CREA CONTO CORRENTE\n");
                ApriConto();
                break;
            case 2:
                Console.WriteLine("Hai scelto: EFFETTUA PRELIEVO\n");
                Prelievo();
                break;

            case 3:
                Console.WriteLine("Hai scelto: EFFETTUA DEPOSITO\n");
                Deposito();
                break;
            case 4:
                Console.WriteLine("Hai scelto: ESCI\n");
                Start();
                break;

        }


    }
    private void ApriConto()
    {
        Console.WriteLine("Inserisci Nome:\n");
        string Nome = Console.ReadLine();
        Console.WriteLine("Inserisci Cognome:\n");
        string Cognome = Console.ReadLine();
        ContoCorrente conto = new ContoCorrente();
        Name = Nome;
        LastName = Cognome;
        Saldo = 0;
        ContoAperto = true;
        Console.WriteLine($"Il C.C intestato a: {Name} {LastName} con saldo {Saldo} è stato aperto\n\n");
        Start();
    }

    private void Prelievo()
    {
        if (ContoAperto == false)
        {
            Console.WriteLine("Il conto non è aperto/non esiste");
        }
        else
        {
            Console.WriteLine("Quanto denaro vuoi prelevare?");
            decimal prelievo = decimal.Parse(Console.ReadLine());
            Saldo += prelievo;
            Console.WriteLine($"Il tuo denaro adesso è di {Saldo}");
            Start();
        }
    }

    private void Deposito()
    {
        if (ContoAperto == false)
        {
            Console.WriteLine("Il conto non è aperto/non esiste");
        }
        else
        {
            Console.WriteLine("Quanto denaro vuoi depositare?");
            decimal deposito = decimal.Parse(Console.ReadLine());
            Saldo -= deposito;
            Console.WriteLine($"Il tuo denaro adesso è di {Saldo}");
            Start();
        }
    }

    public static void Main(string[] args)
        {
            ContoCorrente Conto = new ContoCorrente();
            Conto.Start();
        }
   
  }
