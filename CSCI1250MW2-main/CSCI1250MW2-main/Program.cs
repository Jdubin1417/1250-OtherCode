/*
Console.Write("Is it cold outside? (Yes/No) ");
string coldOut = Console.ReadLine(); 

if(coldOut == "Yes")
{
    System.Console.WriteLine("Wear a coat!");
    System.Console.WriteLine( "... person puts on coat...");
    System.Console.WriteLine( "Person complains it is cold outside.");
    System.Console.WriteLine( "Person feels a little less happy!");
}

//continue on

System.Console.WriteLine( "And they leave!");

System.Console.Write("Enter a number! ");
int num  = Convert.ToInt32(Console.ReadLine());

if(num == 5)
{
    System.Console.WriteLine( "Great you entered 5!");

    if(coldOut == "Yes")
    {
        System.Console.WriteLine("You entered 5 and it's cold outside!");
    }
    else
    {
        System.Console.WriteLine("You entered 5, but it is NOT cold out!");
    }
}
else
{
    System.Console.WriteLine("Then you didn't enter 5!");
}
*/

Console.Write("What is your current grade? ");
double grade = double.Parse(Console.ReadLine());

if(grade < 0 || grade > 100)
{
    Console.WriteLine("You can only enter a number between 0 and 100 inclusivly.");
    Console.Write("What is your current grade? ");
    grade = double.Parse(Console.ReadLine());
}
string letterGrade = "";

if(grade >= 90)
{
    letterGrade = "A";
}
else if(grade >= 80)
{
    letterGrade = "B";
}

else if(grade >= 70)
{
    letterGrade = "C";
}

else if(grade >= 60)
{
    letterGrade = "D";
}
else
{
    letterGrade = "F";
}
//85 letterGrade = B

/*
if(letterGrade == "A" || !(letterGrade == "B"))
{
    System.Console.WriteLine( "you can move on to CSCI 1260!");
}
else if(letterGrade == "C")
{
    System.Console.WriteLine("You passed for most majors! but can't go onto 1260");
}
else
{
    System.Console.WriteLine("I'll see you next semesters. You should have picked Mr. Desjardins over Mr. Rochelle!");
}
*/

switch(letterGrade)
{
    case "A":
    case "B":
        System.Console.WriteLine( "you can move on to CSCI 1260!");
        break;
    case "C":
        System.Console.WriteLine("You passed for most majors! but can't go onto 1260");
        break;
    default:
        System.Console.WriteLine("I'll see you next semesters. You should have picked Mr. Desjardins over Mr. Rochelle!");
        break;
}

int num = 5;
switch(num)
{
    case 1:
        //
        break;
    
    case 2:
        //
        break;
    default:
        //exit the program!
        break;
}

Console.Write("Choose a or b! ");
char letter = Console.ReadLine()[0];
//char firstIn = letterAsString[0];


switch(letter)
{
    case 'A':
    case 'a':
        System.Console.WriteLine("You selected A or a");
        break;
    case 'B':
    case 'b':
        System.Console.WriteLine("You selected B or b");
        break;

}
//double grade = Convert.ToDouble(Console.ReadLine());

