// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
double[] array = new double[6];
FillArray();
PrintArray();
Difference();
void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-10,11);
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

void Difference()
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    Console.WriteLine("Разница между максимальным и минимальным элементом: " + (max - Math.Abs(min)));
}
// Чтобы была разница, нужно брать минимальное число по модулю,иначе если минимум отрицателен,
// то получается сумма