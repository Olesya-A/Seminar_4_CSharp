// 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(CalculateFactorial(n));

int CalculateFactorial(int N)
{
    int factorial = 1;
    for (int i = 2; i <= N; i++)
        factorial = factorial * i;
    return factorial;
}