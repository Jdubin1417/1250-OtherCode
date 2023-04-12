//Lesson on March 21, 2022 covered Methods
Console.Write("Hello :)");

int age = Convert.Toint32(Console.ReadLine());
//-------------------------------------------------
int number = 7;
Console.WriteLine(number);
number = 0;
//The statement on line 1 declares the number variable 
//and initializes it with the value 7.
//The statement in line 2 calls the Console.WriteLine
//method, passing number as an argument.
//      The method does its job, printing the value on the screen, and then terminates.
//The code then resumes at line 3.
//-------------------------------------------------------
int number;
Random rand=new Randon();
number = rand.Next();
//The statement in line 1 declares the number variable.
//Line 2 creates a Random object and assigns its address to a variable named rand.
//Line 3 is an assignment statement, which assigns a value to the number variable.
//Notice the call to the rand.Next method.
//      The method executes then returns a value.
//      The value that is returned is assigned to the number variable.
//---------------------------------------------------------
static void DisplayMessage()
    {
        Console.WriteLine("Hello from the DisplayMessage Method")
    }
// Method modifier – The word static means the method belongs to the class, not a specific object.
//Return type – when the keyword void appears here, it means the method is a void method and does not return a value.
//Method name – You should give each method a descriptive name. In general, you want to apply the same naming rules to methods that you use with variables.
//Parentheses –The method name is always followed by a set of parentheses.Any arguments that the method receives will appear inside the parentheses.
//---------------------------------------------------------------
Console.WriteLine("Hello");
//The statement above calls the Console.WriteLine method ◼ “Hello” is passed as an argument
//-----------------------------------------------------------------
//method call (Using the Methods)
CapitalizeName();

//method declaration (Creating the Methods)
static void DisplayMessage()
    {
        Console.WriteLine(Hello, from the DisplayMessage method);
    }
//-----------------------------------------------------------------
static void Deep()
    {
            Console.WriteLine(Hello, from the Deep method);
            Deeper();
    }
static void Deeper()
    {
            Console.WriteLine(Hello, from the Deeper method);
            Deepest();
    }
static void Deepest()
    {
            Console.WriteLine(Hello, from the Deepest method);
    }
//-----------------------------------------------------------
static void Write(string message)
{
    //display message to the console
}
//--------------------------------------------------------
DisplayValue(5);

static void DisplayValue(int num)
{
    Console.Write$"The value is {num}. "
}
// The argument 5 is copied into the parameter variable num
//-----------------------------------------------------------
static void ShowSumError(double num1, num2); //This will result in error
static void ShowSumError(double num1, double num2); //This will not result in error
//-----------------------------------------------------------
static int sum(int num1, int num2)
{
    int results;

    results = num1 + num2;
    return results;
}

static int sum(int num1, int num2)
{
    int results;

    reeturn = num1 + num2;
}
//You must specify the data type of the return value in the method header
//You must have a return statement in a value-returning method
//Yoou can return any expression that has value
//-----------------------------------------------------------
static int ReturnSum(int num1, int num2)
{
    int sum;
    sum = num1 + num2;
    return sum;
}

Console.WriteLine(ReturnSum(15, 26)); 
//We NEED to do something with the value that ReturnSum returns

