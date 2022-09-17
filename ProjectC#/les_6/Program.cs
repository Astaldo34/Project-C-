// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Задача №41");
Console.WriteLine("Введите массив из 5 чисел: ");
int size = 5;
int[] UserArray = new int[size];
int tmpNum = 0;
int aboveZero = 0;
for (int i = 0; i < size; i++)
{
    tmpNum = Convert.ToInt32(Console.ReadLine());
    UserArray[i] = tmpNum;
    if (UserArray[i] > 0) {
        aboveZero++;
    }
}

Console.WriteLine($"[{String.Join(", ", UserArray)}]");
Console.WriteLine($"Чисел больше нуля - {aboveZero}\n");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задача №43");
Console.Write("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

int y = k2 * ((y - b1) / k1) + b2;
int x = (y - b1) / k1; // хз как это считать тут :)

Console.WriteLine(y);