// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное 
//число в массиве.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[12];
FillArray();
PrintArray();
if (SearchNum()==true) Console.WriteLine("Число " + number + "\t есть в массиве!");
else Console.WriteLine("Число " + number+ "\t не существует в массиве!");
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

bool SearchNum()
{
    for (int i=0; i<array.Length;i++)
    {
        if (array[i]== number) return true;  
    }
    Console.WriteLine(" ");
    return false;
}
