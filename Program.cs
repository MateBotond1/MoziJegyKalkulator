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
Console.WriteLine($"A teljes ár:{alapossz}");