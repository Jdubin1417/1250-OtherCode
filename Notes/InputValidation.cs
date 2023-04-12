int input;

Console.Write("Enter a number from 1-100: ");
input = Convert.ToInt32(Console.ReadLine());

while(input < 1 || input > 100)
{
    System.Console.Write("Invalid input. Enter a number 1-100: ");
    input = Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine($"Good job, you can read! The input was {input}");
