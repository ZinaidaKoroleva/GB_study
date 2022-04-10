// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
Random rand = new Random();
int rows = rand.Next(3, 6);
int colums = rand.Next(3, 6);
int[,] array = new int[rows, colums];
FillArray();
MinSumm();
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

void MinSumm()
{
    int minSumm = 40;
    int indexMinSumm = -1;
    int currentSumm = 0;
    for (int i = 0; i < rows; i++)
    {   
        currentSumm = 0;
        for (int j = 0; j < colums; j++)
        {
            currentSumm += array[i, j];
        }
          if (currentSumm < minSumm)
        {
            minSumm = currentSumm;
            indexMinSumm = i;
        }
     
    }

    Console.WriteLine(" ");
    Console.WriteLine($"Минимальная сумма элементов находится в строке {indexMinSumm+1} и равна {minSumm}");
}
