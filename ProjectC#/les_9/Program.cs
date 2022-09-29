// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Задача №66");

int SumElems(int m, int n) {
    int summ = 0;
    SumRe(m);
    void SumRe(int m) {
        if (m <= n) {
            summ += m;
            m++;
            SumRe(m);
        }
        
    }
    return summ;
};
Console.WriteLine(SumElems(1, 15));
Console.WriteLine(SumElems(4, 8));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("\n" + "Задача №68");

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Akkerman(m - 1, n);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}


Console.WriteLine(Akkerman(3,2)); //Не понял как работает эта функция, что возвращает...