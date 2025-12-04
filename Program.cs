// See https://aka.ms/new-console-template for more information

Console.WriteLine("Tervetuloa Ahmedin laskimeen!");

Console.WriteLine("Anna ensimmäinen luku!"); 
double luku1 = double.Parse(Console.ReadLine());


Console.WriteLine("Anna toinen luku!"); 
double luku2 = double.Parse(Console.ReadLine());

Console.WriteLine("Valitse operaatio: +, -, *, /"); 
string  operaatio = Console.ReadLine();

if ( operaatio == "+") 
{ 
    Console.WriteLine($"{luku1} + {luku2} = {luku1 + luku2}"); 
} 
else if (operaatio == "-") 
{ 
    Console.WriteLine($"{luku1} - {luku2} = {luku1 - luku2}"); 
} 
else if (operaatio == "*") 
{ 
    Console.WriteLine($"{luku1} * {luku2} = {luku1 * luku2}"); 
} 
else if (operaatio == "/") 
{
    if (luku2 == 0)
    {
        Console.WriteLine("404-nollalla ei voi jakaa!😝"); 
    }
    else
    {
        Console.WriteLine($"{luku1} / {luku2} = {luku1 / luku2}");
    }
} 
