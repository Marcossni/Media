double a, b, c;
double media;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());

media = (a + b + c) / 3;


if (media > 3.4)
    {
    Console.WriteLine("Média maior que a ponderada.");
}
 else
{
    Console.WriteLine("Média:");
}
Console.WriteLine(media);
