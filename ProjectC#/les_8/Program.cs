// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Задача №54");

int[,] GetMatrix(int m, int n)
{
    int[,] someMatrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            someMatrix[i,j] = new Random().Next(1, 5);
        }
    }
    return someMatrix;
};

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
};

int[,] FirstMatrix = GetMatrix(4, 4);
PrintMatrix(FirstMatrix);

int[,] SortMatrix(int[,] inputMatrix)
{
    int[,] sortMatrix = new int[inputMatrix.GetLength(0), inputMatrix.GetLength(1)];
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        int [] lineElem = new int [inputMatrix.GetLength(0)];

        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            lineElem[j] = inputMatrix[i, j];
        }
        Array.Sort(lineElem);
        for (int k = 0; k < lineElem.Length; k++)
        {
            sortMatrix[i,k] = lineElem[k];
        }
    };

    return sortMatrix;
};

int[,] sortedMatrix =  SortMatrix(FirstMatrix);
Console.WriteLine("Отсортированная:");
PrintMatrix(sortedMatrix);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine("\n" + "Задача №56");
int[,] TwoMatrix = GetMatrix(5, 4);
PrintMatrix(TwoMatrix);

void GetSummElements(int[,] inputMatrix)
{
    int summElems = 0;
    int min = 9999;
    int line = 0;
    for (int i = 0; i < inputMatrix.GetLength(0); i++) // строчки
    {
    summElems = 0;
        for (int m = 0; m < inputMatrix.GetLength(1); m++) // cтолбцы
        {
            summElems += inputMatrix[i,m];
        }
        if (summElems < min) {
            min = summElems;
            line = i;
        }
        Console.WriteLine($"Сумма строки {i}: {summElems}");
    }
    Console.WriteLine($"Наименьшее сумма в строке - {line}, сумма: {min}");
}

GetSummElements(TwoMatrix);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("\n" + "Задача №58");
int[,] ThreeMatrix = GetMatrix(2, 2);
int[,] FourMatrix = GetMatrix(2, 2);
Console.WriteLine("Первая матрица: ");
PrintMatrix(ThreeMatrix);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(FourMatrix);

int[,] MultiMatrix(int[,] firstMatrix, int[,] twoMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j] = firstMatrix[i,j] * twoMatrix[i,j];
        }
    }
    return resultMatrix;
};

Console.WriteLine("Произведение матриц: ");
int[,] ResultMatrix = MultiMatrix(ThreeMatrix, FourMatrix);
PrintMatrix(ResultMatrix);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)