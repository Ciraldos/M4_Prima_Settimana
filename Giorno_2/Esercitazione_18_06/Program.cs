using Esercitazione_18_06;

internal class Program
{
    public static void Main (string[] args)
    {
        Persona persona = new("Andrea", "Ciraldo", 24);

        Console.WriteLine(persona.getNome());
        Console.WriteLine(persona.getCognome());
        Console.WriteLine(persona.getEta());
        persona.getDettagli();

    }
}