// 
int [] array = new int[5];
FillArray();
PrintArray();
ReversArray();
void FillArray()
{
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100,1000);
    }
}
void PrintArray()
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
     Console.WriteLine();
}

void ReversArray()
{
    int[]secondArray = new int[array.Length];
    int lastindex = array.Length - 1;
    for(int i = 0; i < array.Length; i++)
    {
       secondArray[i] = array[lastindex-i];
    }
    PrintArray();
}
