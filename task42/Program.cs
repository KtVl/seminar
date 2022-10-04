// Задача 42: 
// Напишите программу, 
// которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// вариант 1. короткий способ

// int number = 43;
// string result = Convert.ToString(number, 2);
// Console.WriteLine(result);

// вариант 2. через деление на 2

void task42()
{
    int number=43;
    string result = "";
    while (number > 0)
    {
        result = number%2 + result;
        number/=2;
    }
   Console.WriteLine(result);
}
task42();
