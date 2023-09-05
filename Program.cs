//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
/*
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());
{
    Console.WriteLine("Натуральные числа от N до 1 с помощью рекурсии:");
    PrintNumbers(N);
}    

void PrintNumbers(int n)
{
    if (n >= 1)
    {
    Console.WriteLine(n); 
    PrintNumbers(n - 1); 
    }
}
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());

if (M > N)
{
    Console.WriteLine("M должно быть меньше или равно N.");
}
else
{
    int sum = SumNumbers(M, N);
    Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна {sum}");
}
    
int SumNumbers(int m, int n)
    {
        int sum = 0;
        for (int i = m; i <= n; i++)
        {
            if (i > 0)
            {
                sum += i;
            }
        }
        return sum;
    }
*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

    
int Ackerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackerman(m - 1, 1);
        }
        else
        {
            return Ackerman(m - 1, Ackerman(m, n - 1));
        }
    }

Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine());

int result = Ackerman(m, n);
Console.WriteLine($"Значение функции Аккермана для m = {m} и n = {n} равно {result}");