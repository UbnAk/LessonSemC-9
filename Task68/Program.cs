// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int M = ReadInt($"Введите первое число: ");
int N = ReadInt($"Введите второе число: ");

int ReadInt(string arg)
{
    System.Console.WriteLine(arg);
    return int.Parse(Console.ReadLine());
}

int Akerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akerman(m - 1, 1);
    }
    else
    {
        return (Akerman(m - 1, Akerman(m, n - 1)));
    }
}
System.Console.WriteLine(Akerman(M, N));
