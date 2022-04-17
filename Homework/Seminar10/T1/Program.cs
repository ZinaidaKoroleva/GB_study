// 1. Дано число n. Получите число, записанное в обратном порядке.
Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(number);
Reverse(number);
Console.WriteLine();

void Reverse(int currentNumber, int result = 0)
{
    if (currentNumber == 0)
    {
        Console.Write(" => " + result);
        return;
    }
    result = result * 10 + currentNumber % 10;
    currentNumber /= 10;
    Reverse(currentNumber, result);
}
