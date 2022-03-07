// Дополнительная задача 2
Console.WriteLine("Введите год рождения");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите месяц рождения");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите день рождения");
int day = Convert.ToInt32(Console.ReadLine());
int AYear = 2022 - year;
int  AMonth = 2-month;
if (AMonth<0)
    {
      AMonth= AMonth+12;
      AYear--;  
    }
    int ADay=1-day;
if (ADay<0)
    {
        AMonth--;
       MonthDay(ADay);
    }
string MonthDay(int ADay)
{
    if ((month == 1) || (month == 3) || (month == 5) || (month == 7) || (month == 8) || (month == 10) || (month == 12))
    {
        ADay=31+ADay;
    return ADay;
    }
    if ((month==4)||(month == 6)||(month == 9) || (month == 11)) 
    {
        ADay=30+ADay;
    return ADay;
    }
    if (month==2) 
    {
        ADay=28+ADay;
    return ADay;
    }
    else 
    {
        return "Такого месяца не существует";
    }
}

Console.WriteLine(ADay+ AMonth + AYear);

