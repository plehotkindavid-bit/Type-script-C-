for (int i = 0; i < 10; i++) 
{
for (int j = 1; j <= i; j++)
{Console.Write("*");
    }
Console.WriteLine();
}
for (int i = 10; i > 0; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.Write("Введите высоту треугольника: ");
int height = Convert.ToInt32(Console.ReadLine());

for (int i = height; i >= 1; i--)
{
    // пробелы
    for (int spaces = 0; spaces < height - i; spaces++)
    {
        Console.Write(" ");
    }

    for (int stars = 1; stars <= i; stars++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
