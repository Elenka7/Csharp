// Определим четное ли число
Console.WriteLine("Введите число: ");
string m = Console.ReadLine();
int n = int.Parse(m);

if(n%2 == 0)
{
    Console.WriteLine("Это чётное число");
}
else
{
    Console.WriteLine("Это нечётное число");
}