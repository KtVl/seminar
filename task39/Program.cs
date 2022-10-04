// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


void task39()
{
    int size =10;
    int [] numbers = new int [size];
    FillArray(numbers, -10,10);
    PrintArray(numbers);
    ReversArray(numbers);
    PrintArray(numbers);
}

void ReversArray(int[] numbers)
{
    int size = numbers.Length;
    int maxIndex = size -1;
    for (int i = 0; i < size/2; i++)
    {
        //переворот массива с помощью кортежа
        (numbers [i], numbers[maxIndex-i]) = (numbers[maxIndex-i],numbers [i]);
    }
}

void FillArray(int[] numbers, int minValue =0, int maxValue=9)
{
    maxValue++;
    int size = numbers.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        numbers[i]=random.Next(minValue, maxValue);
    }
}

void PrintArray(int[] numbers)
{
    int size = numbers.Length;
    Console.WriteLine("вывод массива:");
    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[i]+ " ");
    }
    Console.WriteLine();
}

task39();

