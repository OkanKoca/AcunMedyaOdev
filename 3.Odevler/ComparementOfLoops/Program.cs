

// while loop

int i =11;
while (i < 10) // while hiç çalışmaz çünkü 11 < 10 değildir
{
    Console.WriteLine(i);
    i++;
} 

Console.WriteLine();

//do while loop
i = 0;
do // do while ise önce çalışır sonra koşula bakar
{
    Console.WriteLine(i);
    i++;
} while (i < 10);