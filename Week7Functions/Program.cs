Console.WriteLine("Are you coming or leaving? (in/out)");
string userChoice = Console.ReadLine();

if (userChoice == "in" )
{
    PrintHello();
}
else
{
    PrintGoodbye();
}

static void PrintHello() //function / meetod
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodbye()
{
    Console.WriteLine("Bye.");
}