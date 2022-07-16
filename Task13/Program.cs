// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if (number >= 100) Console.WriteLine($"Третья цифра этого числа: {Math.Abs(number / 100 % 10)}");
else Console.WriteLine("Третьей цифры, увы, нет!");