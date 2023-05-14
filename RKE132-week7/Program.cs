
Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodbye();
}


PrintHello();
PrintGoodbye();

static void PrintHello()
{
    Console.WriteLine("Hello World");
}

static void PrintGoodbye()
{
    Console.WriteLine("see you later");
}