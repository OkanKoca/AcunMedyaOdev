int[] numbers = new int[5];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("Bir sayı giriniz: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

int toplam = 0;

foreach (var number in numbers)
{
    toplam += number;
}

Console.WriteLine("Toplam: " + toplam);
