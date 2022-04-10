// Задача 65.Задайте значения M и N. Напишите программу, выводящую натуральные числа от M до N.
int numberM = 1;
int numberN = 10;
Recursion(numberM,numberN);
void Recursion(int m,int n)
{
    if (n + 1 == m) return;
    Console.Write(m + " ");
    Recursion(m+1, n);
}