// 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    int i = 0;
    while(i < size)
    {
        arr[i] = new Random().Next(0,2);
        i++;
    }
    return arr;
}

void PrintArray(int[] arr)
{
        Console.WriteLine($"[{string.Join (", ", arr)}]");
}


PrintArray(CreateArray(8));