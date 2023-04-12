public class Program
{
    static void Main(string[] args)
    {
        // using a class (creating objects)
        Pokemon squirtle = new Pokemon();
        squirtle.SetDexNumber(7);
        squirtle.SetName("Squirtle");
        squirtle.SetLevel(10);
        string[] squirtleTypes = {"water"};
        squirtle.SetTypes(squirtleTypes);
        System.Console.WriteLine(squirtle.ToString());

        string[] mudkipTypes = {"water"};
        Pokemon mudkip = new Pokemon(258, "Mudkip", 15, mudkipTypes);
        System.Console.WriteLine(mudkip);

        string[] lugiaTypes = {"Flying", "Psychic"};
        Pokemon lugia = new Pokemon(249, "Lugia", 99, lugiaTypes);
        System.Console.WriteLine(lugia);
    }
}