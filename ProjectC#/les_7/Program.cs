// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задача №47");

double[,] GetMatrixDouble(int m, int n)
{
    double[,] Somematrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Somematrix[i,j] = new Random().Next(-10,10); 
        }
    }
    return Somematrix;
}

void PrintMatrixDouble(double[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) 
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++) 
        {
            Console.Write(inputMatrix[i,m] + "\t"); 
        }
        Console.WriteLine();
    }
}

double[,] doubleMatrix = GetMatrixDouble(5, 5); 

PrintMatrixDouble(doubleMatrix);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("\n" + "Задача №50");

double GetValue(int rows_position, int column_position) {
    if (rows_position < doubleMatrix.GetLength(0) && column_position < doubleMatrix.GetLength(1)) {
        return doubleMatrix[rows_position, column_position];
    } else {
        Console.WriteLine("Выбраны не допустумые значения!");
        return 0; //можно не возвращать както, типо break ?
    }
}

Console.WriteLine(GetValue(2,2));
Console.WriteLine(GetValue(13,0));

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("\n" + "Задача №52");

int[,] GetMatrix(int m, int n)
{
    int[,] Somematrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Somematrix[i,j] = new Random().Next(1, 5);
        }
    }
    return Somematrix;
}
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) 
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++) 
        {
            Console.Write(inputMatrix[i,m] + "\t"); 
        }
        Console.WriteLine();
    }
}

void GetSummElements(int[,] inputMatrix)
{
    double summElems = 0;
    for (int i = 0; i < inputMatrix.GetLength(1); i++) // строчки
    {
    summElems = 0;
        for (int m = 0; m < inputMatrix.GetLength(1); m++) // cтолбцы
        {
            summElems += inputMatrix[m,i];
        }
    Console.WriteLine($"Среднее арифметическое столбца {i}: {summElems / inputMatrix.GetLength(0)}");
    }
   
}

int[,] realMatrix = GetMatrix(5, 5);
PrintMatrix(realMatrix);
GetSummElements(realMatrix);

