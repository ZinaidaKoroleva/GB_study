// Задача 3. Напишите рекурсивный метод, который принимает номер года и определяет, является ли он високосным или нет.
Console.Write("Введите год: ");
int year = Convert.ToInt32(Console.ReadLine());
if (year % 4 == 0)
{
    Console.WriteLine(year + " год високосный");
}

else LeapYear(year);

void LeapYear(int currentYear, int n = 0)
{
    if (currentYear % 4 == 0)
    {
        Console.WriteLine("Через " + n + " лет будет високосный год " + currentYear);
        return;
    }
    currentYear += 1;
    n += 1;
    LeapYear(currentYear, n);
}
