string name = "Some,String";
char firstLetter = name[0];
char secondLetter = name[1];
var splitStuff = name.Split(',');

string mattsNameAsString = "Matt";

char[] mattsName = {'M','a', 't', 't'};

//int[] numbers = 
int[] stuff = {1, 2, 3, 4, 5};
int[] stuffThatIsBigger = {stuff[0], stuff[1],stuff[2], stuff[3], stuff[4], 6};


int[] sameStuff = new int[5];
sameStuff[0] = 1;
sameStuff[1] = 2;
sameStuff[2] = 3;
sameStuff[3] = 4;
sameStuff[4] = 5;

System.Console.WriteLine( mattsNameAsString[3]);
Console.Write(mattsName[3]);



///Console.Write("How many exams do you have? ");
//int numExams = Convert.ToInt32(Console.ReadLine());
//this needs loops.

int[] exams = new int[3];

Console.Write("Give me your first exam grade! ");
exams[0] = Convert.ToInt32(Console.ReadLine());


Console.Write("Give me your second exam grade! ");
exams[1] = Convert.ToInt32(Console.ReadLine());


Console.Write("Give me your final exam grade! ");
exams[2] = Convert.ToInt32(Console.ReadLine());

double average = (exams[0] + exams[1] + exams[3]) / exams.Length;