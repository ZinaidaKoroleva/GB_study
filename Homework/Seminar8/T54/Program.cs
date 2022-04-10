// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
Random rand = new Random();
int rows = rand.Next(2, 6);
int colums = rand.Next(2, 6);
int[,] array = new int[rows, colums];
FillArray();
Sort();
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

void Sort()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            for (int k = 0; k < colums; k++)
            {
                {
                    if (array[i, k] < array[i, j])
                    {
                        int buff = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k] = buff;
                    }
                }
            }
        }
    }
    Console.WriteLine(" ");
    Console.WriteLine("Отсортированный массив:");
    PrintArray();
}