// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

var rd = new Random();
int[,] matrix = new int[rd.Next(2,4), rd.Next(2,4)];
FillArray(matrix);
int[,] matrix2 = new int[rd.Next(2,4),rd.Next(2,4)];
FillArray(matrix2);
if (matrix.GetLength(0) == matrix2.GetLength(1))
{
    FillArrayMultiplication(matrix,matrix2);
}
else Console.WriteLine("Невозможно найти произведение матриц");

void FillArray(int[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <  matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 4);
        }
        Console.WriteLine();
    }
    PrintArray(matrix);
    Console.WriteLine(" ");
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <  matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArrayMultiplication(int[,] matrix,int[,] matrix2)
{
    Console.WriteLine("Матрица произведений");
    int[,] arrayMultiplication = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            arrayMultiplication[i, j] = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                arrayMultiplication[i, j] += matrix[i, k]* matrix2[k, j];
            }
        }
    }
    PrintArray(arrayMultiplication);
}
