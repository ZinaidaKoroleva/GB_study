// Задача 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае,если это не возможно, программа должна вывести сообщение для пользователя
Random rand = new Random();
int rows = rand.Next(4,5);
int colums = rand.Next(4,5);
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
    if (rows == colums)
    {
    int buff;
   for (int i = 0; i < rows; i++)
    {
        for (int j = i+1; j < colums; j++)
        {
            {
                buff = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = buff;
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine("Новый массив: ");
    PrintArray();
    }
    else Console.WriteLine("Поменять строки и столбцы невозможно");
}