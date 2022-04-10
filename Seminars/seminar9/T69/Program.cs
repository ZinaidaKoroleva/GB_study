// Задача 69. Напишите программу, которая на вход принимает два числа и возводит одно в степень другого с помощью рекурсии.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень,в которую возводится число");
int stepen = Convert.ToInt32(Console.ReadLine());
int result = 1;
Power (stepen);
Console.WriteLine($"Число {number} в степени {stepen} равно {result}");
void Power (int n)
{
    if (n == 0) return;
    result *= number;
    Power (n-1);
}
