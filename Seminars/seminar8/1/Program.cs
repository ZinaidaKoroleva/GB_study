// Задача 53: Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива
Random rand = new Random();
int rows = rand.Next(3,7);
int colums = rand.Next(3,7);
int[,] array = new int[rows, colums];
FillArray();
Reverse();
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

void Reverse()
{   
    int buff;
   for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            if (i == 0)
            {
                buff = array[i,j];
                array[i,j] = array[rows-1,j];
                array[rows-1,j] = buff;
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine("Новый массив: ");
    PrintArray();
}

