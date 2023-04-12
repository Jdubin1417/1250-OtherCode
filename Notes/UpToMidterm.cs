/*  
    ///////////////////////////////////////////////////////
    // INPUT PROCESSING, OUTPUT, AND DEVELOPING STRINGS
    ///////////////////////////////////////////////////////
*/

// output 
Console.WriteLine(12);

// input processing
System.Console.Write("Enter your first name: ");
var firstName = Console.ReadLine();
System.Console.Write("Enter your last name: ");
var lastName = Console.ReadLine();

// todo: tryparse
System.Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter your numeric birth month (e.g., october = 10): ");
int birthMonth = Convert.ToInt32(Console.ReadLine());

// string interpolation :)
string messageI = $"Hello, {firstName} {lastName}! Your intials are {firstName[0]}.{lastName[0]}. and you are {age} years old.";

// string concatenation :(
string messageC = "Hello, " + firstName + " " + lastName + "! Your intials are " + firstName[0] + "." + lastName[0] + "." + " and you are " + age + " years old.";

System.Console.WriteLine(messageI);
System.Console.WriteLine(messageC);

/*  
    ///////////////////////////////////////////////////////
    // DECISION STRUCTURES (IF, ELSE IF, SWITCH)
    ///////////////////////////////////////////////////////
*/

// 'if' statement
if(firstName[0] == 'W')
{
    System.Console.WriteLine("You are a ~winner~");
}

// 'if-else' statement
if(age < 21)
{
    System.Console.WriteLine("You cannot purchase an alcoholic beverage :C");
}
else
{
    System.Console.WriteLine("You can purchase a beverage (drink responsibly) C:");
}


// if-else-if statement
if(age >= 18) 
{
    System.Console.WriteLine("Age bracket:\tADULT");
}
else if(age >= 13) 
{
    System.Console.WriteLine("Age bracket:\tTEENAGER");
}
else if(age >= 4) 
{
    System.Console.WriteLine("Age bracket:\tCHILD");
}
else if(age >=0) 
{
    System.Console.WriteLine("Age bracket:\tBABY");
}
else 
{
    System.Console.WriteLine("Invalid age.");
}

string birthMonthName = "";
// 'switch' statement
switch(birthMonth)
{
    case 1:
        birthMonthName = "January";
        break;
    case 2:
        birthMonthName = "February";
        break;
    case 3:
        birthMonthName = "March";
        break;
    case 4:
        birthMonthName = "April";
        break;
    case 5:
        birthMonthName = "May";
        break;
    case 6:
        birthMonthName = "June";
        break;
    case 7:
        birthMonthName = "July";
        break;
    case 8:
        birthMonthName = "August";
        break;
    case 9:
        birthMonthName = "September";
        break;
    case 10:
        birthMonthName = "October";
        break;
    case 11:
        birthMonthName = "November";
        break;
    case 12:
        birthMonthName = "December";
        break;
    default:
        birthMonthName = "";
        System.Console.WriteLine("Invalid birth month.");
        break;
}

System.Console.WriteLine($"You were born in {birthMonthName}.");

/*  
    ///////////////////////////////////////////////////////
    // LOOPS (FOR, FOREACH, WHILE, DO WHILE)
    ///////////////////////////////////////////////////////
*/

//////////////
// pretest  //
//////////////
var x = 7500;

// while loop - won't iterate because its condition is false
while (x < 100)
{
    System.Console.WriteLine(x);
}

// for loop
System.Console.WriteLine("====== Let's print some numbers! =======");
for(int i = 1; i <= 100; i++)
{
    System.Console.WriteLine(i);
}


//////////////
// posttest //
//////////////

// do while loop

do  // will execute 1 time because posttest
{
    System.Console.WriteLine(x);
} while (x < 100);

