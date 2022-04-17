// 2. Дана монотонная последовательность, в которой каждое натуральное число n встречается ровно n раз: 
// 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ... Дано число m. Выведите первые m членов этой последовательности.

int m = 15;
Console.WriteLine("Выводим " + m + " первых чисел:");
PrintNumbers(m);
Console.WriteLine();

void PrintNumbers(int length, int currentM = 1, int countNumber = 0)
{
    if (length == 0) return;
    length--;
    countNumber++;
    if (countNumber > currentM)
    {
        currentM++;
        countNumber = 1;
    }
    Console.Write(currentM + "\t");

    PrintNumbers(length,currentM,countNumber);
}

