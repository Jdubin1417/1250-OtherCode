/*
    Creating a class (blueprint) that describes
    how Pokemon objects will function and the data
    they will hold.
*/
public class Pokemon
{
    // fields
    private int dexNumber;
    private string name;
    private int level;

    private string[] types;

    // constructors
    public Pokemon()
    {
        name = "";
        dexNumber = 0;
        level = 0;
        types = new string[2];
    }
    public Pokemon(int dexNumber, string name, int level, string[] types)
    {
        this.dexNumber = dexNumber;
        this.name = name;
        this.level = level;
        this.types = types;
    }

    // getter/accessor
    public int GetDexNumber() { return dexNumber; }
    public string GetName() { return name; }
    public int GetLevel() { return level; }
    public string[] GetTypes() { return types; }

    // setter/mutator
    public void SetDexNumber(int dexNumber) { this.dexNumber = dexNumber; }
    public void SetName(string name) { this.name = name; }
    public void SetLevel(int level) { this.level = level; }
    public void SetTypes(string[] types) { this.types = types; }

    public override string ToString()
    {
        string pokemonString = "";
        pokemonString += "---------------------------------\n";
        pokemonString += $"Dex No.:\t{dexNumber}\n";
        pokemonString += $"Name:\t\t{name}\n";
        pokemonString += $"Level:\t\t{level}\n";

        string typesString = "";
        foreach(string type in types){typesString += type + " "; }

        pokemonString += $"Type(s):\t{typesString}\n";
        pokemonString += "---------------------------------\n";
        return pokemonString;
    }
}