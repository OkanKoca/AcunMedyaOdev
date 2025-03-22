double birinciSayi;
double ikinciSayi;
string islem;

Console.Write("yapmak istediginiz islem (+,-,*,/) :");
islem = Console.ReadLine();

if (islem == "+")
{
    Console.Write("Birinci Sayı: ");
    birinciSayi = Convert.ToDouble(Console.ReadLine());
    Console.Write("İkinci Sayı: ");
    ikinciSayi = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Sonuç: " + (birinciSayi + ikinciSayi));
}
else if (islem == "-")
{
    Console.Write("Birinci Sayı: ");
    birinciSayi = Convert.ToDouble(Console.ReadLine());
    Console.Write("İkinci Sayı: ");
    ikinciSayi = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Sonuç: " + (birinciSayi - ikinciSayi));
}
else if (islem == "*")
{
    Console.Write("Birinci Sayı: ");
    birinciSayi = Convert.ToDouble(Console.ReadLine());
    Console.Write("İkinci Sayı: ");
    ikinciSayi = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Sonuç: " + (birinciSayi * ikinciSayi));
}
else if (islem == "/")
{
    Console.Write("Birinci Sayı: ");
    birinciSayi = Convert.ToDouble(Console.ReadLine());
    Console.Write("İkinci Sayı: ");
    ikinciSayi = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Sonuç: " + (birinciSayi / ikinciSayi));
}
else
{
    Console.WriteLine("Hatalı işlem girdiniz.");
}   



