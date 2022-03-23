// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
int[] array = new int[8];
Random random = new Random();
for (int i = 0; i<7;i++)
{
    array[i]=random.Next(0,2);
    Console.Write(array[i]+ "");
}


