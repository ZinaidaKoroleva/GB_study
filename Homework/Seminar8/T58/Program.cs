// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int rows = 3;
int colums = 3;
int[,] arrayFirst = new int[rows, colums];
FillArrayFirst();
int[,] arraySecond = new int[rows, colums];
FillArraySecond();
int[,] arraySecondReverse = new int[rows, colums];
FillArraySecondReverse();
int[,] arrayMultiplication = new int[rows, colums];
FillArrayMultiplication();

void FillArrayFirst()
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            arrayFirst[i, j] = rand.Next(0, 4);
        }
    }
    PrintArray();
    Console.WriteLine(" ");
}
void FillArraySecond()
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            arraySecond[i, j] = rand.Next(0, 4);
        }
    }
    PrintArraySecond();
}
void FillArraySecondReverse()
{
    for (int j = 0; j < rows; j++)
    {
        for (int i = 0; i < colums; i++)
        {
            arraySecondReverse[i, j] = arraySecond[j, i];
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(arrayFirst[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void PrintArraySecond()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(arraySecond[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void FillArrayMultiplication()
{
    Console.WriteLine("Матрица произведений");
    int summ = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            summ = 0;
            for (int k = 0; k < colums; k++)
            {
                summ += arraySecondReverse[i, j] * arrayFirst[i, j];
            }
            arrayMultiplication[i, j] = summ;
        }
        Console.WriteLine();
    }
    PrintArrayMultiplication();
}
void PrintArrayMultiplication()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(arrayMultiplication[i, j] + " ");
        }
        Console.WriteLine();
    }
}