// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].
int[] array = new int[123];
FillArray();
PrintArray();
Number();
Console.WriteLine("В отрезке содержится " + Number() + " чисел");
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

int Number ()
{
    int summ = 0;
    int L = array.Length;
    for(int i = 0; i < L; i++)
    {   
        if (array[i]<=99 && array[i]>=10)
        {
            summ = summ + 1;
        }
    }
    return summ;
} 