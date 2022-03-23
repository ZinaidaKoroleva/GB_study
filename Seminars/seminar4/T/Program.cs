// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Zadacha());
int Zadacha()
{
int summ = 0;
for (int i = 1; i<=number; i++)
{
    summ += i;
}
return summ;
}