// See https://aka.ms/new-console-template for more information
Console.Write("nombres : ");
string nom = Console.ReadLine();
Console.Write("apellidos : ");
string ape = Console.ReadLine();
Console.Write("edad  : ");
int edad = int.Parse(Console.ReadLine());
Console.Write("singo zodiacal : ");
string hob = Console.ReadLine();
Console.WriteLine("==================INFORMACION=================");
Console.WriteLine($"eres {nom} {ape}.");
Console.WriteLine($"tienes {edad} años.");
Console.WriteLine($"y tu hobby es {hob}");
Console.Write("=================================================");