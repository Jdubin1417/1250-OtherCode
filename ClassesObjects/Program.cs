public class Program
{
    static void Main(string[] args)
    {
        int len, wid;
        System.Console.WriteLine("Enter a length: ");
        len = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter a width: ");
        wid = Convert.ToInt32(Console.ReadLine());


        // creating an object involves two things:
        // 1. Create the reference variable (Rectangle r1)
        // 2. Assign a reference to a new object in memory to it (= new Rectangle())
        Rectangle r1 = new Rectangle();
        Rectangle r2 = new Rectangle(len, wid);
        Rectangle r3 = new Rectangle(200,400);

        // using mutators (setters)
        // r1.SetLength(16);
        // r1.SetWidth(14);

        // r2.SetLength(24);
        // r2.SetWidth(5);

        System.Console.WriteLine();

        // using accessors (getters)
        System.Console.WriteLine($"The length of r1 is {r1.GetLength()}");
        System.Console.WriteLine($"The width of r1 is {r1.GetWidth()}");
        System.Console.WriteLine($"The area of r1 is {r1.GetArea()}");

        System.Console.WriteLine($"The length of r2 is {r2.GetLength()}");
        System.Console.WriteLine($"The width of r2 is {r2.GetWidth()}");
        System.Console.WriteLine($"The area of r2 is {r2.GetArea()}");

        System.Console.WriteLine($"The length of r3 is {r3.GetLength()}");
        System.Console.WriteLine($"The width of r3 is {r3.GetWidth()}");
        System.Console.WriteLine($"The area of r3 is {r3.GetArea()}");

    }
}