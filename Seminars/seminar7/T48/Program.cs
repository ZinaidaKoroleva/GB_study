// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
// A = m+n. Выведите полученный массив на экран.
Console.WriteLine("Введите количество строк");
 int rows = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите количество столбцов");
 int colums = Convert.ToInt32(Console.ReadLine());
 int [,] array = new int[rows,colums];
 FillArray();
void FillArray()
 {
     for(int i= 0; i < rows; i++)
     {
         for (int j = 0; j<colums; j++)
         {
             array[i,j] = i + j;
         }
     }
     PrintArray();
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
