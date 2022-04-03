// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
Random rand = new Random();
int rows = rand.Next(2,6);
int colums = rand.Next(2,6);
int [,] array = new int[rows,colums];
FillArray();
Console.WriteLine($"В массиве " + rows + " строк и " + colums + " столбцов");
Console.WriteLine("Введите номер строки");
int findRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int findColums = Convert.ToInt32(Console.ReadLine());
if (findRows>rows || findColums>colums) Console.WriteLine("Такого элемента нет");
else
{
Console.WriteLine($"Искомое значение " + array[findRows -1 ,findColums - 1]);
}
Console.WriteLine("Этот массив был задан:");
PrintArray();
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
}

void PrintArray()
 {
     for(int i= 0; i < rows; i++)
     {
         for (int j = 0; j<colums; j++)
         {
            Console.Write(array[i,j] + " ");
         }
         Console.WriteLine();
     }
 }
