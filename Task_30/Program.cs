﻿// 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];
FillArray(array);
PrintArray(array);


void FillArray(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    while(index < length)
    {
        arr[index] = new Random().Next(0,2);
        index ++;
    }
}

void PrintArray(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    while(index < length)
    {
        Console.Write($"{arr[index]} ");
        index++;
    }
}