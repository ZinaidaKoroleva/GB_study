Console.WriteLine("Напишите цифру дня недели");
int day = Convert.ToInt32(Console.ReadLine());
string Holiday(int day)
{
    if ((day == 6) | (day==7))
    {
        return day + " -это выходной день";
    }
    if ((day >= 1) & (day<= 5))
    {
        return day + " -это рабочий день";
    }
   else
    {
        return "Такого дня недели нет";
    }
}
Console.WriteLine(Holiday(day));
