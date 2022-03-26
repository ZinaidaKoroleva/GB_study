// 32 Напишите программу замены элементов массива. 
//Положительные элементы замените на соответствующие отприцательные и наоборот.
int[] array = new int[12];
FillArray();
PrintArray();
Replacement();
void FillArray()
{
    Random rand = new Random();
    for (int i=0; i<array.Length; i++)
    {
        array[i] = rand.Next(-9,10);
    }
}

void PrintArray()
{
    for (int i=0; i< array.Length;i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

void Replacement()
{
   
    for (int i=0; i<array.Length;i++)
    {
            array[i] = array[i] * -1;
            Console.Write(array[i]+ " ");
    }
}