//Lessons on March 28, 2022 covering Methods
     //.net run looks at code and looks for main method, 

//Normal Hello World program but main method is typed out
public class MyClass
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Hello World!");
    }

//Method with method inside
public class MyClass
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Let's call some methods!");
        System.Console.WriteLine($"You are {GetAge()} years old.");
        System.Console.WriteLine(ComputeAge("3/29/2001");
    }
    static int GetAge()
    {
        System.Console.WriteLine("Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());
    }
       //Date Format: MM/DD/YYYY
       //             04/25/2001

    static DateTime ComputeAge(string dateOfBirth)
    {
        // 1. Get Current Date
        var currentDate = DateTime.Now;
        var dateSplit = dateOfBirth.Split("/");

        //dateSplit = 3 things: {month} [day] [year]
        //                      [  0  ] [ 1 ] [ 2  ]
        int birthYear = Convert.ToInt32(dateSplit[2]);
        int birthMonth = Convert.ToInt32(dateSplit[0]);
        int birthDay = Convert.ToInt32(dateSplit[1]);
        int currentMonth = currentDate.Month;
        int currentDay = currentDate.Day;
        int age = currentDate.Year - birthYear;

        return age;

        if(currentMonth > birthMonth)
        {
            return age--;
        }
        else if (currentMonth == birthMonth)
        {
            //check days
            if(currentDay >= birthDay)
            {
                return age;
            }
            else
            {
                return age--;
            }
        }

        return age;
        
        foreach(string date in dateSplit)
        {
            System.Console.WriteLine(Date);
        }

        return currentDate.Date;
        
    }
}
    
    //var threeCubed = Math.Pow(3.0, 3.0);
        //Random rand = new.Random();

    //dotnet run --argument "Hi" 
    //dotnet run --"Hi"
    //dotnet run "Hi"







