// напишите программу, которая на вход
// принимает число и выдает,
// является ли оно четным


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)

    {
        Console.WriteLine(number + " - Четное число: ");
    }

    else
    
    {
        Console.WriteLine(number + " - Нечетное число");
    }