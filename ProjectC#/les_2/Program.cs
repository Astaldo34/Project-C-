// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите 3-х значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 100 && number <= 999) {
    int secondNum = (number / 10) % 10;
    Console.WriteLine($"в числе {number}, вторая цифра - {secondNum}");
};

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
string? someNumber = Console.ReadLine();

if (someNumber.Length >= 3) {
    Console.WriteLine($"в числе {someNumber}, третья цифра - {someNumber[2]}");
} else {
    Console.WriteLine("третьей цифры нет");
};

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

while (true) {
    Console.Write("Введите число от 1 до 7: ");
    int numberDay = Convert.ToInt32(Console.ReadLine());

    if (numberDay >= 1 && numberDay < 8) {
        string nameDay = "Понедельник";
        bool isDayOff = false;
        switch(numberDay) {
            case 2: nameDay = "Вторник";
            break;
            case 3: nameDay = "Среда";
            break;
            case 4: nameDay = "Четверг";
            break;
            case 5: nameDay = "Пятница";
            break;
            case 6: nameDay = "Суббота";
                isDayOff = true;
            break;
            case 7: nameDay = "Воскресенье";
                isDayOff = true;
            break;
        }
        Console.WriteLine($"День недели - {nameDay} и это {(isDayOff ? "Выходной!" : "Рабочий")}");
        break;
    } else {
        Console.WriteLine("Введено не корректное число, попробуйте ещё раз");
    };
};

// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// Console.Write("Введите 3-х значную цифру ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 100 && num < 999) {
//     int num_1 = num / 100;
//     int num_2 = num % 10;
//     string res = Convert.ToString(num_1) + Convert.ToString(num_2);
//     Convert.ToInt32(res);
//     Console.WriteLine($"{num_1}{num_2}");
//     Console.WriteLine($"{res}");
// };



// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.WriteLine("Введите 2 числа: ");
// int n_1 = Convert.ToInt32(Console.ReadLine());
// int n_2 = Convert.ToInt32(Console.ReadLine());

// if (n_1 % n_2 == 0) {
//     Console.WriteLine($"Число {n_2} кратно {n_1}");
// } else {
//     Console.WriteLine(n_1 % n_2);
// };


// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.WriteLine("Введите число: ");
// int number_1 = Convert.ToInt32(Console.ReadLine());

// if (number_1 % 7 == 0 && number_1 % 23 == 0) {
//     Console.WriteLine($"Число кратно 7 и 23");
// } else {
//     Console.WriteLine("Не кратно!");
// };

// int [] array = {1, 3, 5, 7};
// foreach (int var in array) {
//  Console.WriteLine(var);
// };

