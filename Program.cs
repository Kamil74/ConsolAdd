// See https://aka.ms/new-console-template for more information

    Console.WriteLine("What's your name?");
    string userName = Console.ReadLine();
    Console.WriteLine("Hello");

    Console.WriteLine(userName);

    string someText = "Some text";

    char jchar = 'j';
    char jCharUnicod = '\u006A';

    //do spelnienia warunku

    bool isUserReady = false;

    //sprawdzanie czasu
    DateTime now = DateTime.Now;
    DateTime dateOfBirth = new DateTime( 1990,6,6);
    Console.WriteLine(dateOfBirth);

    byte byteNumber = 200;
    float floatNumber = 1.5F;
    decimal decimalNumber = 1.5M;
    double doubleNumber = 1.5;



    string message1;
    message1 = "some value";
    Console.WriteLine(message1);
    string message2 = null;
    Console.WriteLine(message2);

string message3 =string.Empty;
string text = "He said \"Hi\"";
Console.WriteLine(text);
string windowLocation = "c:\\windows";
Console.WriteLine(windowLocation);


int result;
int x = 10;
int y = 5;

result = (x + y);
Console.WriteLine("Addition Operator: x + y = " + result);
result = (x - y);
Console.WriteLine("Subtraction Operator: x - y = "+result);
result = (x * y);
Console.WriteLine("multiplication Operator: x * y = "+result);
result = (x / y);
Console.WriteLine("Division Operator: x / y = "+result);
result = (x % y);
Console.WriteLine("Modulo Operator: x % y = "+result);
int value = (2 + 2) * 5;

Console.WriteLine("*****************");

int value1 = 10;
int value2 = 10;
Console.WriteLine("Pre-increment result:");
Console.WriteLine(++value1);

Console.WriteLine("Pre-increment result:");
Console.WriteLine(value2++);
Console.WriteLine(value2);

#region ProgramClassRegion
Console.WriteLine("*****************");
bool boolResult;
boolResult = (x == y);
Console.WriteLine("Equal to Operator: (x == y)=" + boolResult);
boolResult = (x > y);
Console.WriteLine("Greator than Operator: (x > y)=" + boolResult);
boolResult = (x < y);
Console.WriteLine("Less than Operator: (x < y)=" + boolResult);
boolResult = (x >= y);
Console.WriteLine("Greator then or Equal: (x >= y)=" + boolResult);
boolResult = (x <= y);
Console.WriteLine("Lesser then or Equal: (x <= y)=" + boolResult);
boolResult = (x != y);
Console.WriteLine("not Equal to Operator: (x != y)=" + boolResult);


Console.WriteLine("**********************");

bool a = true;
bool b = false;

boolResult = a && b;
Console.WriteLine("AND Operator: a && b = " + boolResult);
boolResult = a || b;
Console.WriteLine("OR Operator: a || b = " + boolResult);
boolResult =  !a ;
Console.WriteLine("ANOT Operator: !a  = " + boolResult);

Console.WriteLine("******************");
x = 5;
y = 10;

int greateNumber = x > y ? x : y;
Console.WriteLine("Ternary conditional operator: x > y ? X : y = " + greateNumber);
#endregion
{
    Console.WriteLine("Year of birth?");
    string userImput = Console.ReadLine();
    int yearOfBirth = int.Parse(userImput);
    bool isUserOver18 = DateTime.Now.Date.Year - yearOfBirth > 18;
    if (isUserOver18)
    {
        Console.WriteLine("hello");
    }
    else if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
    {
        Console.WriteLine("Oh well its Sunday");
    }
    else
    {
        Console.WriteLine("Access denied");
    }
    Console.WriteLine("bay");
}

Console.WriteLine("********************");

switch (DateTime.Now.DayOfWeek)
{
    case DayOfWeek.Monday:
        Console.WriteLine("It's Monday ;(");
        break;
        case
    DayOfWeek.Friday:
        Console.WriteLine("The last day of the work week");
        break;
        case DayOfWeek.Sunday:
    case DayOfWeek.Saturday:
        Console.WriteLine("The weekend!");
        break;
        default: 
        Console.WriteLine("The middle of the work week");
        break;
}
Console.WriteLine("************************");


