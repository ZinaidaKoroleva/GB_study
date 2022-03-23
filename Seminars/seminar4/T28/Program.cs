// Задача 28: Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

Console.WriteLine("ВВедите число");
int num = Convert.ToInt32(Console.ReadLine());
int number = 1;
int factorial=1;
while (number<= num)
{
    factorial=factorial*number;
    number++;
}
Console.WriteLine(factorial);