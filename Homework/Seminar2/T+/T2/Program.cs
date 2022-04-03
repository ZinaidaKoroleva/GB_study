// Дополнительная задача 2
Console.WriteLine("Введите год рождения");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите месяц рождения");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите день рождения");
int day = Convert.ToInt32(Console.ReadLine());
int AYear = 2022 - year;
int AMonth = 2 - month;
if (AMonth < 0)
{
    AMonth = AMonth + 12;
    AYear--;
}
int ADay = 1 - day;
if (ADay < 0)
{
    AMonth--;
    MonthDay(ADay);
}
int MonthDay(int month)
{
    switch (month)
    {
        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12:
            return 31;
        case 2: 
            return 28;
        default: 
            return 30;
    }
}

Console.WriteLine("Ваш возраст на 01.02.2022: " + AYear + " лет, " + AMonth + " месяца(ев), " + ADay + " дня(ей).");

