var total = 0;    // accumulator

System.Console.Write("How many numbers do you want to add: ");
var max = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= max; i++)
{
    System.Console.Write("Enter a number: ");
    var input = Convert.ToInt32(Console.ReadLine());

    total += input;
}

System.Console.WriteLine($"The total is {total}");