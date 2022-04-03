//Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int colums = Convert.ToInt32(Console.ReadLine());
double [,] array = new double[rows, colums];
FillArray();
void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = rand.NextDouble()*100;
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