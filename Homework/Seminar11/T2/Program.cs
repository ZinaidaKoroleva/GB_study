// Задача 2. Двумерный массив заполнен случайными натуральными числами от 1 до 10. 
//Найдите количество элементов, значение которых больше 5, и их сумму.
int [,] array = new int[4,4];
FillArray(array);
PrintArray(array);
Result(array);
void FillArray(int [,] matrix)
{
    Random rd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]=rd.Next(1,11);
        }
    }
}

void PrintArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void Result (int [,]matrix)
{
    int summ = 0;
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j]> 5)
            {
                summ += matrix[i,j];
                n++;
            }

        }
    }
    Console.WriteLine("Сумма элементов больше 5 равна " + summ+ ", количество этих элементов: " + n);
}