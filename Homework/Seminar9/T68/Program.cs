// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
int startNumber = 3;
int finishNumber = 4;
Recursion(startNumber,finishNumber);
Console.WriteLine("Значение функции Аккермана равно: " + Recursion(startNumber,finishNumber));
int Recursion(int m, int n)
{
    if (m==0) return n+1;
    else if (n==0) return Recursion(m-1,1);
    else return Recursion(m-1,Recursion(m,n-1));
}
