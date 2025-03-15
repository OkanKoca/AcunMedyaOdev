using ACNMDYA05.Classes;
using System.Collections;

Addition addition = new Addition();
ArrayList numbers = new ArrayList();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
Console.WriteLine(addition.Sum(numbers));