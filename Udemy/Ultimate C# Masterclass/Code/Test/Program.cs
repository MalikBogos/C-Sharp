//Schrijf een R-script dat de som berekent van alle even getallen tussen 1 en 100, en het resultaat afdrukt.

int getal = 1;
while(getal <= 100)
{
    int waarde = 0;
    if (getal % 2 == 0)
    {
        Console.WriteLine("De uitkomst is:");
        waarde += getal;
        Console.WriteLine(waarde);
    }
    getal += 1;
}
Console.ReadKey();

// addition