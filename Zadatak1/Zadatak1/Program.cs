// See https://aka.ms/new-console-template for more information

bool opet = true;
while (opet)
{
    opet = false;
    Console.WriteLine("Unesite broj: ");
    int unos = Convert.ToInt32(Console.ReadLine());
    int x; double rezultat;
    switch (unos)
    {
        case 1:
            x = 5;
            rezultat = Math.Pow(x, 3) + 3 * x;
            Console.WriteLine("Rezultat je: " + rezultat);
            break;
        case 2:
            x = 2;
            rezultat = Math.Abs(x) + Math.Pow(x, 2) + Math.Sqrt(x);
            Console.WriteLine("Rezultat je: " + rezultat);
            break;
        default:
            Console.WriteLine("Morate uneti brojeve 1 ili 2");
            opet = true;
            break;
    }
}