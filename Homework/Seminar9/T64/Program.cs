// Задача 64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber<secondNumber)
{
   Recursion(firstNumber,secondNumber); 
}
else 
{
    int buff;
    buff = firstNumber;
    firstNumber = secondNumber;
    secondNumber = buff;
    Recursion(firstNumber,secondNumber);
}

void Recursion(int n, int m)
{
    if (n>m) return;
    if (n%3==0)
    Console.Write(n + " ");
    Recursion(n+1,m);
}

