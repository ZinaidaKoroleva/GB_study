// Задача 41. Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

int count = Convert.ToInt32(Console.ReadLine());
int count_pos = 0;
for (int i = 0; i<count;i++)
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number>0) count_pos++;
}
Console.WriteLine("Количество чисел больше нуля: " + count_pos);