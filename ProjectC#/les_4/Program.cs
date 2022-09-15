// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Задача №1.");

int NumberPower(int A, int B) {
    int result = A;
    for (int i = 1; i < B; i++)
    {
        result *= A;
    }
    return result;
}

Console.WriteLine(NumberPower(3,5));
Console.WriteLine(NumberPower(2,4));


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Задача №2.");

void SumChar(int num) {
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    Console.WriteLine($"Сумма чисел = {sum}");
}

SumChar(452);
SumChar(82);
SumChar(9012);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Задача №3.");
//Пример решения не понятен, в одной строке там выводиться 5 элементов, в другой 3. Сделал через Random.

void CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100);
    }
    Console.WriteLine($"[{String.Join(", ", array)}]");
}

CreateArray(8);

