// Задача 63*. Задайте значение N. напишите программу, которая выведет все натуралльные числа в промежутке от N до 1.

int number = 12;
Recursion(number);
void Recursion(int n)
{
    if (n == 0) return;
    Console.WriteLine(n);
    Recursion(n-1);
}

