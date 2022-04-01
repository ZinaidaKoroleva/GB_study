// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, colums];
FillArray();
Console.WriteLine("--------------");
Console.WriteLine("Новый массив");
ChangeToSquare();
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

void ChangeToSquare()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            if (i % 2 == 0 && j % 2 == 0) array[i, j] *= array[i, j];
        }
    }
    PrintArray();
}
