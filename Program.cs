/*
    Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
    */
    
    int ResultNumbers(int m, int n)
    {
        if (m == n)
            return m;
        return ResultNumbers(m + 1, n) + m;
    }
    
    Console.Clear();
    Console.WriteLine("Введите 1-е число: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2-е число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    while (m >= n)
    {
        Console.WriteLine();
        Console.WriteLine("1-е число должно быть меньше второго");
        Console.WriteLine();
        Console.WriteLine("Введите 1-е число: ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 2-е число: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"Сумма всех чисел в диапазоне от {m} до {n} равна: {ResultNumbers(m, n)}");

