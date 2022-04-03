//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Random rand = new Random();
int rows = rand.Next(3,7);
int colums = rand.Next(3,7);
int[,] array = new int[rows, colums];
FillArray();
Console.WriteLine("Среднее арифметическое(без остатков): ");
Average();
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

void Average()
{
    int summ = 0;
    for (int j = 0; j < colums; j++)
    {   
        summ = 0;
        for (int i = 0; i < rows; i++)
        {
            summ += array[i, j];
        }
        int average = summ/rows;
        Console.Write(average + " ");
    }
    Console.WriteLine();
}

