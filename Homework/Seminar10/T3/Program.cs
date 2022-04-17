// 3. Дано натуральное число n > 1. Вывести все простые множители данного числа.
int n = 453;
Console.Write("Простые множители числа " + n);
Console.WriteLine();
PrimeFactors(n);
Console.WriteLine();

void PrimeFactors(int currentNumber = 1, int factors = 1)
{
    if (currentNumber == 1) return;

    factors++;

    if (currentNumber % factors == 0)
    {
        Console.Write(factors + "\t");
        currentNumber /= factors;
        factors = 1;
    }

    PrimeFactors(currentNumber, factors);
}
