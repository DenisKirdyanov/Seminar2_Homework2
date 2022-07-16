// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());

while (number >= 1000 | number <= -1000 | (number<100 & number > -100))
{
    Console.WriteLine("Вы ввели не трехзначное число, повторите ввод:");
    number = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Вторая цифра этого числа: {Math.Abs(number % 100 / 10)}");