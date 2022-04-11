// Задача 64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
int startNumber = 1;
int finishNumber = 15;
Recursion(startNumber,finishNumber);
void Recursion(int n, int m)
{
    if (n>m) return;
    if (n%3==0)
    Console.Write(n + " ");
    Recursion(n+1,m);
}

