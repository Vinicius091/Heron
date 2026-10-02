double lado1, lado2, lado3;
double semiperímetro;
double área;

Console.WriteLine("---Calculo da área de um triângulo---");
Console.WriteLine();

Console.WriteLine("lado1..: ");
lado1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("lado2..: ");
lado2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("lado3..: ");
lado3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

semiperímetro = (lado1 + lado2 + lado3) / 2;

área = Math.Sqrt(semiperímetro * (semiperímetro - lado1) * (semiperímetro - lado2) * (semiperímetro - lado3));

Console.WriteLine($"Semiperímetro..: {semiperímetro}");
Console.WriteLine($"Área...........: {área}");
