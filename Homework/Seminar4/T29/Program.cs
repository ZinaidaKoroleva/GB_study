// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел 
// и выводит отсортированный по модулю массив.

int[] array = new int[8];
Random random = new Random();
for (int i = 0; i < 7;i++)
{
    array[i]=random.Next(-1001,1001);
}
BubbleSort(array);
for (int i = 0; i < 7;i++)
{
    Console.Write(array[i]+ "  ");
}
void BubbleSort()
		{
			for (int i = 0; i < 7; i++)
				for (int j = 0; j < 7; j++)
					if (Math.Abs(array[j]) > Math.Abs(array[j + 1]))
					{
						int buff = array[j + 1];
						array[j + 1] = array[j];
						array[j] = buff;
					}
		}