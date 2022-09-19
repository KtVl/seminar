// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int digitIndex = 2; 

if (num < 0)
{
    num = -num;
}
if (num > 100)
{
    int digit = num.ToString()[digitIndex] - '0';
    Console.WriteLine("Третья цифра " + digit);
}
else
{
    Console.WriteLine($"В числе {num} третьей цифры нет");
}
