// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;
using Zadatak3;

Korisnik k1 = new Korisnik("Stevan", "Mihailovic", "mihailovic023@gmail.com");
Korisnik k2 = new Korisnik("Marko", "Markovic", "Markovic@gmail.com");
Korisnik k3 = new Korisnik("Ivana", "Vuletic", "123@gmail.com");

Hotel Vojvodina = new Hotel(4300, 3, false);
Hotel Garden = new Hotel(8900, 5, true);
Hotel NoviSad = new Hotel(6700, 4, true);
Hotel Beograd = new Hotel(9840, 5, true);
Hotel Jugoslavija = new Hotel(7760, 5, true);
Hotel Hilton = new Hotel(5090, 4, false);
Hotel RadissonBlue = new Hotel(9330, 5, true);

Apartman VilaKikinda = new Apartman(3200, true);
Apartman ApartmaniZlatibor = new Apartman(2200, false);
Apartman VilaUna = new Apartman(1400, false);
Apartman VilaAna = new Apartman(4320, true);
Apartman LepaBrena = new Apartman(1800, false);
Apartman CasaDeTara = new Apartman(6000, true);

List<Korisnik> korisnici = new List<Korisnik>();

korisnici.Add(k1);
korisnici.Add(k2);
korisnici.Add(k3);

List<Hotel> hoteli = new List<Hotel>();

hoteli.Add(Vojvodina);
hoteli.Add(Garden);
hoteli.Add(NoviSad);
hoteli.Add(Beograd);
hoteli.Add(Jugoslavija);
hoteli.Add(Hilton);
hoteli.Add(RadissonBlue);

List<Apartman> apartmani = new List<Apartman>();

apartmani.Add(VilaKikinda);
apartmani.Add(ApartmaniZlatibor);
apartmani.Add(VilaUna);
apartmani.Add(VilaAna);
apartmani.Add(LepaBrena);
apartmani.Add(CasaDeTara);


List<Rezervacija> rezervacije = new List<Rezervacija>();
int BrojRezervacija = 0;

bool opet = true, opet2;
/* Koristio sam while petlje kako me ne bi program konstantno izbacivao nakon pogresnog unosa, takodje dok program traje zapisuju se 
   dosadasnje rezervacije u listu. Odabirom 99 na pocetku mozemo videti ukupne cene proslih rezervacija. Za izlazak iz programa pritisnuti enter ili neki drugi simbol kako bi 
   napravili gresku i izasli iz programa.
 */
while (opet)
{
    opet = false;
    Console.WriteLine("-------------------------------------------------------------------------------------");
    Console.Write("Dobrodosli! Izaberite korisnika: (0 - Stevan, 1 - Marko, 2 - Ivana) \n ili unesite 99 da pogledate sve cene svih rezervacija u sistemu: ");
    int index = Convert.ToInt32(Console.ReadLine());
    if (index != 0 && index != 1 && index != 2)
    {
        if (index == 99)
        {
            
            if (BrojRezervacija == 0)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Trenutno ne postoji ni jedna rezervacija u sistemu");
                Console.WriteLine("--------------------------------------------------");
            }
            else
            {
                Console.WriteLine("--------------------------");
                foreach (var rez in rezervacije)
                {
                    rez.IzracunajUkupnuCenu();
                }
                Console.WriteLine("--------------------------");
            }
        }
        opet = true;
        Console.WriteLine("morate birati korisnika od 0 do 2");
    }
    
    else
    {
        opet2 = true;
        while (opet2)
        {
            opet2 = false;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Da li zelite hotel - 0 ili apartman? - 1");
            int TipSmestaja = Convert.ToInt32(Console.ReadLine());
            int i = 0, Unos, BrojNoci;
            switch (TipSmestaja)
            {
                case 0:
                    Console.WriteLine("--------------------------");
                    foreach (var h in hoteli) // moze se raditi i (for int o = 0; o < hoteli.lenght; o++) Console.WriteLine(hoteli[o].ToString()
                    { 
                        Console.WriteLine(i + "." + h.ToString());
                        i++;
                    }
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Izaberite neki od ovih hotela po indexu: ");
                    Unos = Convert.ToInt32(Console.ReadLine());
                    if(Unos < 0 || Unos > hoteli.Count-1)
                    {
                        Console.WriteLine("Ne postoji hotel sa datim indexom");
                        opet2 = true;
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine("Ukucajte broj noci koje zelite da provedete u hotelu: ");
                        BrojNoci = Convert.ToInt32(Console.ReadLine());
                        Rezervacija r = new Rezervacija(korisnici[index], hoteli[Unos], BrojNoci);
                        r.IzracunajUkupnuCenu();
                        BrojRezervacija++;
                        rezervacije.Add(r);
                        opet = true;
                        
                    }
                    break;
                case 1:
                    Console.WriteLine("--------------------------");
                    foreach (var a in apartmani)
                    {
                        Console.WriteLine(i + "." + a.ToString());
                        i++;
                    }
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Izaberite neki od ovih apartmana po indexu: ");
                    Unos = Convert.ToInt32(Console.ReadLine());
                    if (Unos < 0 || Unos > apartmani.Count - 1)
                    {
                        Console.WriteLine("Ne postoji apartman sa datim indexom");
                        opet2 = true;
                    }
                    else
                    {
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("Ukucajte broj noci koje zelite da provedete u apartmanu : ");
                        BrojNoci = Convert.ToInt32(Console.ReadLine());
                        Rezervacija r = new Rezervacija(korisnici[index], apartmani[Unos], BrojNoci);
                        r.IzracunajUkupnuCenu();
                        BrojRezervacija++;
                        rezervacije.Add(r);
                        opet = true;
                        
                    }
                    break;
                default:
                    Console.WriteLine("Izaberite izmedju 0 i 1");
                    opet2 = true;
                    break;
            }
        }
        
    }
}
