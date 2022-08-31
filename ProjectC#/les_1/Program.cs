// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

using static System.Linq.Enumerable; // для задачи №8

Console.WriteLine("Введите последовательно 2 числа");
int num_1 = int.Parse(Console.ReadLine());
int num_2 = int.Parse(Console.ReadLine());

if (num_1 > num_2) {
    Console.WriteLine($"Первое число - {num_1} больше второго - {num_2}");
} else {
    Console.WriteLine($"Второе число - {num_2} больше первого - {num_1}");
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
num_1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
num_2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int num_3 = int.Parse(Console.ReadLine());

if (num_1 > num_2 && num_1 > num_3) {
    Console.WriteLine($"Первое число больше всех - {num_1}");
} else if (num_2 > num_1 && num_2 > num_3) {
    Console.WriteLine($"Второе число больше всех - {num_2}");
} else {
    Console.WriteLine($"Третье число больше всех - {num_3}");
};

int[] arr = {num_1, num_2, num_3};
Console.WriteLine($"Максимальное число с помощью встроенного метода массива Max() - {arr.Max()}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
num_1 = int.Parse(Console.ReadLine());

if ((num_1 % 2) == 0) {
    Console.WriteLine($"Число {num_1} - чётное");
} else {
    Console.WriteLine($"Число {num_1} - нечётное");
};

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
num_1 = int.Parse(Console.ReadLine());

foreach (int item in Range(1, num_1)) {
    if ((item % 2) == 0) {
        Console.WriteLine($"Число {item} - чётное");
    };
};