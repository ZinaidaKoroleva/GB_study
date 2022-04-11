// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
int startNumber = 3;
int finishNumber = 5;
int summ = 0;
Recursion(startNumber, finishNumber, summ);
void Recursion(int n, int m, int s)
{
    if (n > m)
    {
        Console.WriteLine("Сумма элементов от " + startNumber + " до " + finishNumber + " равна: " + s);
        return;
    }
    s += n;
    Recursion(n + 1, m, s);
}
