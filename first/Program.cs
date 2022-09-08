﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
string[] first;
string[] second;
Init(out first);
Solve(out second);
Print();



















void Init(out string[] arr)
{
    Console.Write("Введите количество строк в массиве:  ");
    int n = Convert.ToInt32(Console.ReadLine());
    arr = new string[n];

    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите строку № {(i + 1)}:  ");
        arr[i] = Console.ReadLine();
    }

}

void Solve(out string[] arr)
{
    int val = 0;
    int count = 0;
    for (int i = 0; i < first.Length; i++)
    {
        if (first[i].Length < 4)
            count++;
    }
    arr = new string[count];
    for (int i = 0; i < first.Length; i++)
    {
        if (first[i].Length < 4)
        {
            arr[val] = first[i];
            val++;
        }
    }
}

void Print()
{
    System.Console.WriteLine();
    System.Console.WriteLine("Итоговый массив: ");
    for (int i = 0; i < second.Length; i++)
        Console.WriteLine($"Строка № {(i+1)}: {second[i]} ");
}