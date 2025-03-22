int randomNumber = new Random().Next(1, 101);


do
{
    Console.Write("Tahmininizi giriniz: ");
    int guess = int.Parse(Console.ReadLine());
    if (guess < randomNumber)
    {
        Console.WriteLine("Daha büyük bir sayı giriniz.");
    }
    else if (guess > randomNumber)
    {
        Console.WriteLine("Daha küçük bir sayı giriniz.");
    }
    else
    {
        Console.WriteLine("Tebrikler, doğru tahmin!");
        break;
    }
} while (true);
