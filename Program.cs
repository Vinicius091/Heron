double lado1, lado2, lado3;
double perimetro;
double area;

Console.WriteLine("---Calculo da área de um triângulo---");
Console.WriteLine();

Console.WriteLine("lado1");
lado1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("lado2");
lado2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("lado3");
lado3 = Convert.ToDouble(Console.ReadLine());

area = Math.Sqrt(perimetro * (perimetro - lado2) * (perimetro - lado3));

perimetro = (lado1 + lado2 + lado3) / 2;

Console.WriteLine($"Semiperímetro..: {perimetro}");
Console.WriteLine($"Área...........: {area}");
