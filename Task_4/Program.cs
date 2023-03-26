// Находим max из трёх чисел
Console.WriteLine("Введите три числа: ");
string input1 = Console.ReadLine();
string input2 = Console.ReadLine();
string input3 = Console.ReadLine();
int number1 = int.Parse(input1);
int number2 = int.Parse(input2);
int number3 = int.Parse(input3);
int max = number1;

if(number1 > max) max = number1;
if(number2 > max) max = number2;
if(number3 > max) max = number3;

 Console.Write("max = ");
 Console.WriteLine(max); 