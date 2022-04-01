// Напишите программу, которая будет создавать 
//копию заданого массива с помощью поэлементного копирования
int[] array = new int[12];
FillArray();
PrintArray();
Copy();
PrintArray();
void FillArray()
{
    Random rand = new Random();
    int L = array.Length;
    for (int i=0; i<L; i++)
    {
        array[i] = rand.Next(-10,201);
    }
}
void PrintArray()
{
    int L = array.Length;
    for (int i=0; i<L;i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

void Copy ()
{
    int[] SecondArray = new int[array.Length];
    int L = SecondArray.Length;
    for(int i = 0; i < L; i++)
    {   
        SecondArray[i]=array[i];
    }
} 
