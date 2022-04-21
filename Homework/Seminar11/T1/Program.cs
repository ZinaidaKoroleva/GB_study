// Задача 1. На вход подаются два числа n и m, такие, что n<m. Заполните массив случайными числами из промежутка [n, m].
int n = 2;
int m = 5;
int Length = 10;
int[] array = new int[Length];
FillArray(array, Length);
void FillArray(int[] matrix, int matrixLength)
{
    Random rand = new Random();
    for (int i = 0; i < matrixLength; i++)
    {
        matrix[i] = rand.Next(n, m + 1);
        Console.Write(matrix[i] + "  ");
    }
}