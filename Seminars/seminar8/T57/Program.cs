// Задача 57. Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Random rand = new Random();
int rows = rand.Next(4,5);
int colums = rand.Next(4,5);
int[,] array = new int[rows, colums];
int [] dictionary = new int[10];
FillArray();
PrintDictionary();
Dictionary();
PrintDictionary();
void PrintDictionary()
{
    Console.WriteLine();
    Console.WriteLine("Частотный словарь");
    for (int i=0;i<dictionary.Length;i++)
    {
        Console.Write(dictionary[i] + " ");
    }
}
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

void Dictionary()
{   
     for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            dictionary[array[i,j]]++;
        }
    }  
  
}
