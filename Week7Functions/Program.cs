Console.WriteLine("Are you coming or leaving? (in/out)");
string user = Console.ReadLine();

if(user == "in")
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
    Console.WriteLine("Hello, world!");
}

static void PrintGoodbye()
{
    Console.WriteLine("See you later.");
}


