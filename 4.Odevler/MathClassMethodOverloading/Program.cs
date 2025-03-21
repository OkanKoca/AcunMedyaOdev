using MathClassMethodOverloading;

Matematik mat = new Matematik();

Console.WriteLine(mat.Topla(5, 3)); // int topla
Console.WriteLine(mat.Carp(5, 3)); // int carp
Console.WriteLine(mat.Bol(8, 4));
Console.WriteLine(mat.Cikar(15, 3));

Console.WriteLine(mat.Topla(5.5, 3)); // double topla
Console.WriteLine(mat.Carp(5.5, 3)); // double carp