public class Program
{
    public static string Username { get; set; }
    public static string Password { get; set; }
    public static string ConfermaPassword { get; set; }
    
    public static DateTime Data;

    public static int cont = 0;

    public static bool isLogged = false;



    private void Start()
    {
        Console.WriteLine("+++++++ MENU +++++++");
        Console.WriteLine("Opzione 1: Login");
        Console.WriteLine("Opzione 2: Logout");
        Console.WriteLine("Opzione 3: Verifica Data");
        Console.WriteLine("Opzione 4: Lista Accessi");
        Console.WriteLine("Opzione 5: Esci");
        
        int x = int.Parse(Console.ReadLine());
        switch (x)
        {
            case 1: Console.WriteLine("Hai cliccato: LOGIN");
                    Login();
                    break;
            case 2: Console.WriteLine("Hai cliccato: LOGOUT");
                    Logout();
                    break;
            case 3: Console.WriteLine("Hai cliccato: Verifica Data");
                    VerificaData(); 
                    break;
            case 4: Console.WriteLine("Hai cliccato: Lista Accessi");
                    ListaAccessi();
                    break;
            case 5: Console.WriteLine("Hai cliccato: Esci");
                    Esci();
                    break;
        }
    }

    private static void Login() {

        Program p = new Program();
        Console.WriteLine("Inserisci Username:");
        Username = Console.ReadLine();
        Console.WriteLine("Inserisci Password:");
        string Password = Console.ReadLine();
        Console.WriteLine("Inserisci nuovamente la Password:");
        string newPassword = Console.ReadLine();
        if (Username != null)
        {
            if (Password == newPassword)
            {
                Console.WriteLine("Sei stato autenticato!");
                isLogged = true;
                Data = DateTime.Now;
                cont++;
                p.Start();
                
            }
            else Console.WriteLine("Le password non coincidono");
        }
        else Console.WriteLine("L'username non esiste");
    }
    private static void Logout() {
        Program p = new Program();
        if (isLogged)
        {
            Username = "";
            Password = "";
            ConfermaPassword = "";
            isLogged = false;
            Console.WriteLine("L'utente è stato disconnesso");
            p.Start();
        }
        else
        {
            Console.WriteLine("L'utente non è loggato");
            p.Start();
        }


    }
    private static void VerificaData() {
        if (isLogged)
        {
            Console.WriteLine($"L'utente si è loggato alle ore {Data}");
        }
        else Console.WriteLine("ERRORE: Nessun utente è al momento loggato");
    }
    private static void ListaAccessi() {
        Program p = new Program();
        Console.WriteLine($"L'utente si è loggato {cont} volte");
        p.Start();
    }
    private static void Esci() { 
        Environment.Exit(0);
    }

    public static void Main(string[] args)
    
        { 
        Program program = new Program();
        program.Start();
    }

}