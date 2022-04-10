// Задача 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int buff = number;
int summ = 0;
SummNumber();
void SummNumber()
{
    if (number == 0) return;
    summ += number%10;
    number /= 10;
    SummNumber();
}
Console.WriteLine("Cумма цифр числа " + buff + " равна " + summ);
