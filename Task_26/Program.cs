// 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.


Console.Write ("Введите N: ");
int n = int.Parse (Console.ReadLine ()!);   // 12345

int count = 0;

while (n > 0) {  // n == 1
    int digit = n % 10;  // достать последнюю цифру
    n = n / 10;
    count ++;  // оставить всё, кроме последней цифры
}
Console.WriteLine(count);