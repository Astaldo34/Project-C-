// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
string? fiveNumbers = Console.ReadLine();

if (fiveNumbers[0] == fiveNumbers[4] && fiveNumbers[1] == fiveNumbers[3]) Console.WriteLine("да");
else Console.WriteLine("нет");

//сделал для числа любой длины
bool isPalindrom = false;
for (int i=0; fiveNumbers.Length > i; i++) {
    if (fiveNumbers[i] == fiveNumbers[fiveNumbers.Length - i - 1]) isPalindrom = true;
    else isPalindrom = false;
    Console.WriteLine(fiveNumbers[i]);
};
Console.WriteLine($"{(isPalindrom ? "да" : "нет")}");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("Введите координату Х1:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y1:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z1:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х2:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y2:");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"Расстояние между точками в 3D пространстве: {Math.Round(d,2)}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int someNum = Convert.ToInt32(Console.ReadLine());

for (int i=1; someNum + 1 > i; i++) {
    Console.WriteLine(Math.Pow(i, 3));
};
