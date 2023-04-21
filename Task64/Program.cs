// Задайте значение N. Напишите программу, которая выведет все
//  натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int N = ReadInt();

int ReadInt()
{
    System.Console.WriteLine("Введите число N: ");
    return int.Parse(Console.ReadLine());
}

void DerivationOfNaturalNum(int N)
{
    if (N>0)
    {
    System.Console.WriteLine(N);
    DerivationOfNaturalNum(N-1);
    }
}
DerivationOfNaturalNum(N);