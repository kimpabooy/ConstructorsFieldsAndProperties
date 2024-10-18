namespace Övningar___Constructors__Fields___Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bok1 = new Bok("Sagan om ringen", "Tolkien", 267 );
            var bok2 = new Bok("Bamse", "Rune Andréasson", 20 );
            var bok3 = new Bok("hej", "Toen", 167 );
            
            Console.WriteLine($"bok 1, Titel: {bok1.Titel} Författare: {bok1.Författare} Sidantal: {bok1.Sidantal}\n");
            Console.WriteLine($"bok 2, Titel: {bok2.Titel} Författare: {bok2.Författare} Sidantal: {bok2.Sidantal}\n");
            Console.WriteLine($"bok 3, Titel: {bok3.Titel} Författare: {bok3.Författare} Sidantal: {bok3.Sidantal}\n");

            Console.ReadKey();
        }
    }
}
