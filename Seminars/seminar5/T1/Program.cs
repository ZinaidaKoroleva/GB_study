//Задайте массив из 12 элементов, заполненный случайными числами из промежутся [-9,9]
// Найдите сумму отрицательных и положительных элементов массива
int[] array = new int[12];
FillArray();
PrintArray();
Search();
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

void Search()
{
    int summPos = 0;
    int summNeg = 0;
    for (int i=0; i<array.Length;i++)
    {
        if (array[i]>0)
        {
            summPos += array[i];
        }
        else
        {
            summNeg += array[i];
        }
    }
    Console.WriteLine($"Сумма положительных чисел: {summPos}");
    Console.WriteLine($"Сумма положительных чисел: {summNeg}");
}