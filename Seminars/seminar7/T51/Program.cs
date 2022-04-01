﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, colums];
Console.WriteLine("Вывод массива: " );
FillArray();
FindSumm();
void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
    PrintArray();
}

void PrintArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindSumm()
{   
    int summ = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            if (i==j) summ = summ + array[i,j];
        }
    }
    Console.WriteLine("Cумма элементов на диагонали равна: " + summ);
}

