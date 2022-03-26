double lado1, lado2, lado3, s, a;

Console.WriteLine("digite o 1lado:");
lado1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("digite o 2lado");
lado2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("digite o 3lado");
lado3 = Convert.ToDouble(Console.ReadLine());

s = (lado1 + lado2 + lado3) /2;

a = Math.Sqrt(s * (s-lado1)* (s-lado2)* (s-lado3));

Console.WriteLine($"Semiperimetro:{s}");
Console.WriteLine($"Area:{a}");