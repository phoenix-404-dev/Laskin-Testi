// See https://aka.ms/new-console-template for more information

Console.WriteLine("Tervetuloa Ahmedin laskimeen!");

Console.WriteLine("Anna ensimmäinen luku!"); 
float luku1 = float.Parse(Console.ReadLine());


Console.WriteLine("Anna toinen luku!"); 
float luku2 = float.Parse(Console.ReadLine());

Console.WriteLine("Valitse operaatio: +, -, *, /"); 
string  operaatio = Console.ReadLine();

if ( operaatio == "+") 
{ 
    Console.WriteLine($"Tulos on: {luku1 + luku2}"); 
} 
else if (operaatio == "-") 
{ 
    Console.WriteLine($"Tulos on: {luku1 - luku2}"); 
} 
else if (operaatio == "*") 
{ 
    Console.WriteLine($"Tulos on: {luku1 * luku2}"); 
} 
else if (operaatio == "/") 
{
    if (luku2 == 0)
    {
        Console.WriteLine("Perkeleeee, nollalla ei voi jakaa!"); 
    }
    else
    {
        Console.WriteLine($"Tulos on: {luku1 / luku2}");
    }
} 
