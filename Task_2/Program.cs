// Находим max из двух чисел
Console.WriteLine("Введите два числа: ");
string input1 = Console.ReadLine();
string input2 = Console.ReadLine();
int number1 = int.Parse(input1);
int number2 = int.Parse(input2);
int max = number1;

if (number1 > number2)
{
    max = number1;
}
else
{
    max = number2;
}
 Console.Write("max = ");
 Console.WriteLine(max); 