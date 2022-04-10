// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая построчно выведет элементы и их индексы.
double[,,] array = new double[3,3,3];
int length = 3;
FillArray();
void FillArray()
{
    DateTime dt = new DateTime();
    var random = new Random((int)dt.Ticks);
    for (int i = 0; i <length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            for (int k = 0; k < length; k++)
            {
                array[i,j,k] = random.Next(10,100);
            }
        }
    }
    PrintArray();
    Console.WriteLine(" ");
}
void PrintArray()
{
    for (int i = 0; i <length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            for (int k = 0; k < length; k++)
            {
                Console.WriteLine($"Число {array[i,j,k]} + c индексами [ {i}. {j}. {k}]");
            }
        }
    }
}