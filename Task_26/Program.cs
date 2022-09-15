// 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(CalculateLength(n));


int CalculateLength(int N)
{
    int count = 0;

    while (N > 0)
    {
        // int digit = N % 10; 
        N = N / 10;
        count = count + 1;
    }
    return count;
}

// Алгоритм, который позволяет достать по 1 цифре из числа

// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine()!); // 12345

// while (n > 0) // n == 1
// { 
//     int digit = n % 10; // достать последнюю цифру
//     Console.WriteLine(digit);
//     n = n / 10; // оставить всё, кроме последней цифры, и перезаписать n
// }

