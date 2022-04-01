// See https://aka.ms/new-console-template for more information
 int rows = 3;
 int colums = 4;
 int [,] array = new int[rows,colums];
 FillArray();
 void FillArray()
 {
     Random rand = new Random();
     for(int i= 0; i < rows; i++)
     {
         for (int j = 0; j<colums; j++)
         {
             array[i,j] = rand.Next (0,10);
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