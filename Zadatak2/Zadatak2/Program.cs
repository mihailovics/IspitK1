// See https://aka.ms/new-console-template for more information
using System.Linq;

Console.WriteLine("Dobrodosli u MojKutak");
Random r = new Random();
int[] ocene = new int[20];
for (int i = 0; i < ocene.Length; i++)
{
    ocene[i] = r.Next(1, 11);
    Console.WriteLine(ocene[i]);
}
Console.WriteLine("Prosecna ocena restorana je: " + IzracunajProsecnuOcenuRestorana(ocene));
Console.WriteLine("Maximalna ocena je: " + PronadjiNajvisuOcenu(ocene));

double IzracunajProsecnuOcenuRestorana(int[] ocene)
{
    // U ovom slucaju znamo koliko clanova postoje u nizu ali cu se praviti da ne znam pa stoga prolazim kroz svaki clan niza i belezim koliko ima ukupno clanova
    double zbir = 0;
    for (int i = 0; i < ocene.Length; i++)
    {
        zbir += ocene[i];
    }
    return zbir / ocene.Length;
}
int PronadjiNajvisuOcenu(int[] ocene)
{
    int maximalan = ocene[0];
    for (int i = 1; i < ocene.Length; i++)
    {
        if (ocene[i] > maximalan)
            maximalan = ocene[i];
    }
    return maximalan;
    // Moze i na jos nacina bez mnogo koda koristeci Linq i Ienumerable, ali mislim da su sporiji nego nacin na koji sam ja dosao: 
    // return ocene.Max();
    // return ocene.OrderByDescending(x => x).First();
}


