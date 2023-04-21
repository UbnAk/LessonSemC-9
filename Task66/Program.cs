//  Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = ReadInt($"Введите первое число: ");
int N = ReadInt($"Введите второе число: ");

int ReadInt(string arg)
{
    System.Console.WriteLine(arg);
    return int.Parse(Console.ReadLine());
}

int SumInt(int M, int N)
{
    int sum = M;
    if (M<N)
    {
        M++;
        return sum + SumInt(M,N);
    }
    return sum;
}
System.Console.WriteLine(SumInt(M,N));

