// Найдём все чётные числа от 1 до N с учетом отрицательных
Console.WriteLine(" Введите число: ");

int number = int.Parse(Console.ReadLine());

if (number > 0)
{
    for (int i = 2; i <= number; i = i + 2)
    {
        Console.WriteLine(i);
    }
}
else
{
    for (int z = number; z < 0; z++)
    {
        if (z % 2 == 0)
        {
            Console.WriteLine(z);
        }
    }
}