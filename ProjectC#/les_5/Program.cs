// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задача №34");

int[] FirstArray = new int[10];
int evenNum = 0;

for (int i = 0; i < FirstArray.Length; i++)
{
    FirstArray[i] = new Random().Next(1, 1000);
    if (FirstArray[i] % 2 == 0) {
        evenNum++;
    } 
}

Console.WriteLine($"[{String.Join(", ", FirstArray)}]");
Console.WriteLine($"Количество чётных элементов - {evenNum}\n");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задача №36");

int[] TwoArray = new int[10];
int sumNum = 0;

for (int i = 0; i < TwoArray.Length; i++)
{
    TwoArray[i] = new Random().Next(1, 10);
    if (TwoArray[i] % 2 != 0) {
        sumNum += TwoArray[i];
    } 
}

Console.WriteLine($"[{String.Join(", ", TwoArray)}]");
Console.WriteLine($"Сумма нечётных элементов - {sumNum}\n");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Задача №38");

double[] realArray = new double[10];
double min = 0;
double max = 0;

for (int i = 0; i < realArray.Length; i++)
{
    realArray[i] = new Random().Next(-10, 10); // NextDouble - странное использование от 0.00 до 1.00
    if (realArray[i] < min) min = realArray[i];
    if (realArray[i] > max) max = realArray[i];
}

Console.WriteLine($"[{String.Join(", ", realArray)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива - {max - min}");

// // Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Console.WriteLine("Задача №32");

// int[] array = {-4, -8, 8, 2};

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i] * -1;
// }
// Console.WriteLine($"[{String.Join(", ", array)}]");

// // Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// // 4; массив [6, 7, 19, 345, 3] -> нет
// // -3; массив [6, 7, 19, 345, 3] -> да

// Console.WriteLine("Задача №33");

// int[] TwoArray = {6, 7, 19, 345, 5};

// bool isTrue = false;
// for (int i = 0; i < TwoArray.Length; i++)
// {
//     if (TwoArray[i] == 4) {
//         isTrue = true;
//         break;
//     }
// };

// Console.WriteLine($"{(isTrue ? "Да" : "Нет")}");

// // Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// // Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// // [5, 18, 123, 6, 2] -> 1
// // [1, 2, 3, 6, 2] -> 0
// // [10, 11, 12, 13, 14] -> 5

// Console.WriteLine("Задача №35");

// int size = 123;
// int[] LargeArray = new int[size];
// int n = 0;
// for (int i = 0; i < LargeArray.Length; i++)
// {
//     LargeArray[i] = new Random().Next(1, 100);
//     if (LargeArray[i] >= 10 && LargeArray[i] < 99) {
//         n++;
//     } 
// }

// Console.WriteLine($"[{String.Join(", ", LargeArray)}]");
// Console.WriteLine($"Количество элементов - {n}");
