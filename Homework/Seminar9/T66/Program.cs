// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int summ = 0;
Recursion(firstNumber, secondNumber, summ);
void Recursion(int n, int m, int s)
{
    if (n > m)
    {
        Console.WriteLine("Сумма элементов от " + firstNumber + " до " + secondNumber + " равна: " + s);
        return;
    }
    s += n;
    Recursion(n + 1, m, s);
}
