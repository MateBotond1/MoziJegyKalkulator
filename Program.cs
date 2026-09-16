Console.WriteLine("Írja be a nevét:");
string VNev = Console.ReadLine();
Console.WriteLine("Írja be az életkorát:");
int Életkor = int.Parse(Console.ReadLine());
Console.WriteLine("van diákod?('Igen' v. 'Nem' )");
string Diak = Console.ReadLine();
Console.WriteLine("Mozijegy ára:");
int Mozijegyar = int.Parse(Console.ReadLine());
Console.WriteLine("Popcorn db");
int PopcornDB = int.Parse(Console.ReadLine());
Console.WriteLine("Popcorn ára");
int PopcornAR = int.Parse(Console.ReadLine());
Console.WriteLine("Kedvezmény");
double Kedvezmeny = double.Parse(Console.ReadLine());
bool Allapot = false;
if (Diak == "Igen" || Diak == "igen")
{
    Allapot=true;
}
int alapossz = PopcornAR * PopcornDB + Mozijegyar;
double Tossz = alapossz;
if (Életkor < 18 || Allapot == true)
{
    double Tked = 1 - Kedvezmeny;
    Tossz = alapossz * Tked;
}
Console.WriteLine("--------ÖSSZESÍTŐ--------");
Console.Write("Vásárló neve: ");
Console.WriteLine($"{VNev} ({Életkor})");
Console.Write("Rendelés: ");
Console.WriteLine($"1 db Mozijegy + {PopcornDB} db Popcorn");
Console.Write("Alapösszeg: ");
Console.WriteLine($"{alapossz} Ft");
Console.Write("Fizetendő végösszeg: ");
Console.WriteLine($"{Tossz} Ft ");
if (Allapot == true)
{
    Console.Write("Státusz: ");
    Console.WriteLine($"{Kedvezmeny * 100}% kedvezmény érvényesítve!");
}