using System;

List<byte> csapadek = new List<byte>();

//Random random = new Random();

//for (int i = 0; csapadek.Count != 365; i++)
//{
//    if (random.Next(1, 8) == 1)
//    {
//        csapadek.Add((byte)random.Next(1, 31));
//    }
//    else if (i > 170 && i < 235)
//    {
//        if (random.Next(1, 18) == 1)
//        {
//            csapadek.Add((byte)random.Next(1, 20));
//        }
//    }
//    else
//    {
//        csapadek.Add(0);
//    }
//}

//for (int i = 0; i < csapadek.Count; i++)
//{
//    Console.WriteLine(csapadek[i]);
//}

//File.WriteAllLines("C:\\adatok\\csapadek.txt", csapadek.Select(szam => szam + ""));

//2b)
csapadek = File.ReadAllLines("C:\\adatok\\csapadek.txt").Select(sor => Convert.ToByte(sor)).ToList();
int napok_10felett = 0;
for (int i = 0; i < csapadek.Count; i++)
{
    if (csapadek[i] >= 10)
    {
        napok_10felett++;
    }
}

Console.WriteLine($"Napok 10mm felett: {napok_10felett}");

//3c)
int csapadekos_napok = 0;
int ossz = 0;
for (int i = 0; i<csapadek.Count; i++)
{
    if (i < 170 || i > 235)
    {
        csapadekos_napok++;
        ossz += csapadek[i];
    }
}
double atlag = Convert.ToDouble(ossz)/Convert.ToDouble(csapadekos_napok);
Console.WriteLine($"A csapadékos napok átlaga: {atlag}");

//3d)
for (int i = 0; i < csapadek.Count; i++)
{
    if (csapadek[i]>=35 && csapadek[i + 1] >= 35)
    {
        Console.WriteLine("Történt");
    }
    else
    {
        Console.WriteLine("Nem történt");
    }
}