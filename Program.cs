/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int ResultNumbers(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return ResultNumbers (m - 1, 1);
    else
        return ResultNumbers(m - 1, ResultNumbers(m, n - 1)); ;
}

Console.Clear();
Console.WriteLine("Введите 1-е число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (m < 0 || n < 0)
{
    Console.WriteLine();
    Console.WriteLine(" Число должно быть положительным или 0 ");
    Console.WriteLine();
    Console.WriteLine("Введите 1-е число: ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2-е число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
    Console.WriteLine($"Функция Аккермана равна A(m,n): {ResultNumbers(m, n)}");
