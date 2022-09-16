// напишите программу, которая на вход принимает два числа и выдает, 
// какое число большее,а какое меньшее

 
 
Console.WriteLine("Введите первое число: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)

{
    Console.WriteLine( " наибольшее число " + num1);
    Console.WriteLine( " наименьшее число " + num2);
}

else if (num2 > num1)

{
    Console.WriteLine(" наибольшее число " + num2);
    Console.WriteLine( " наименьшее число " + num1);
}

else

{
    Console.WriteLine(num2 + " = " + num1);
}