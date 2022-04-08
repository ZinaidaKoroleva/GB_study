// Задача 59.Задайте двумерный массив из целых чисел. Напишите программу, 
//которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива
Random rand = new Random();
int rows = rand.Next(3, 6);
int colums = rand.Next(3, 6);
int[,] array = new int[rows, colums];
FillArray();
FindMin();
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

void FindMin()
{
    
    int[,] arrayNew = new int[rows-1, colums-1];
    int min = array[0, 0];
    int minIndexI=0;
    int minIndexJ=0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            {
                if (min > array[i, j])
                {
                    min = array[i, j];
                    minIndexI = i;
                    minIndexJ = j;
                }
            }
        }
    }
    Console.WriteLine("Минимальное число " + min);
    int second_i=0;
    int second_j=0;
    for (int i = 0; i < rows; i++)
    {
        if (i!=minIndexI)
        {
            second_j=0;
            for (int j = 0; j < colums; j++)
            {
                    if (j!=minIndexJ)
                    {
                        arrayNew[second_i,second_j]=array[i,j];
                        second_j++;
                    }
            }
            second_i++;
        }
    }
    
    for (int i = 0; i < arrayNew.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNew.GetLength(1); j++)
        {
            Console.Write(arrayNew[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
}
