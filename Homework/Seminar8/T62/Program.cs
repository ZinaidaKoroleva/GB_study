// Задача 62: Заполните спирально массив 4 на 4 числами от 1 до 16.
// Записывала с ваших слов на семинаре, самостоятельно решить не вышло.
Random rand = new Random();
int sizeX = 4;
int sizeY = 4;
int[,] matrix = new int[sizeX, sizeY];
int indexX = 0;
int indexY = 0;
FillArray();
void FillArray()
{
    int changeX=0;
    int changeY=1;
    int steps = sizeY;
    int direction = 0;
    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[indexX,indexY]=i+1;
        steps--;
        if (steps == 0)
        {
            steps = sizeY * ((direction)%2) + sizeX*((direction+1)%2) -1 - direction/2;
            int temp = changeX;
            changeX = changeY;
            changeY = -temp;
            direction++;
        }
        indexX +=changeX;
        indexY +=changeY;
    }
    PrintArray();
}

void PrintArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

