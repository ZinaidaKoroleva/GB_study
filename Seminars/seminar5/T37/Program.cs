// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент
// второй и предпоследний и т.д. Результат запишите в новом массиве.
Random rand = new Random();
int L = rand.Next(8,10);
int[] array = new int[L];
FillArray();
PrintArray();
multiplication();
void FillArray()
{
    Console.Write("Задан массив: ");
    Random rand = new Random();
    for (int i=0; i<L; i++)
    {
        array[i] = rand.Next(0,11);
    }
}
void PrintArray()
{
    for (int i=0; i<L;i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

void multiplication ()
{
    int MaxIndex = L-1;
    Console.Write("Произведения пар чисел: ");
    for(int i = 0; i < L / 2; i++)
    {   
       Console.Write(array[i] * array[MaxIndex - i ]+ " ");
    }
    
} 
