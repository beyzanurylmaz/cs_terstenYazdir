// See https://aka.ms/new-console-template for more information

string isim;
Console.Write("Bir isim giriniz : ");

isim = Console.ReadLine()!;

for (int i = isim.Length - 1; i >= 0; i--)
{
    Console.WriteLine(isim[i]);
}

