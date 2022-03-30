// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = new int[6];
FillArray();
PrintArray();
Summ();

void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(1, 11);
    }
}
void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void Summ()
{
    int summ = 0;
    for(int i = 1; i < array.Length; i+=2)
    {
        summ += array[i];
    }
    Console.WriteLine($"Сумма нечетных элементов в массиве:  {summ}");
}