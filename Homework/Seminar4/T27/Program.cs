// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int buff = number;
int sum = 0;
while (number > 0)
{
    int num=number%10;
    sum = sum+num;
    number=number/10;
}
Console.WriteLine("Сумма цифр числа " + buff + " равна " + sum);