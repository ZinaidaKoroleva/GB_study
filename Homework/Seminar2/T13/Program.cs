// Задача 13
Console.WriteLine("Введите число");
string a = Console.ReadLine();
IncorrectNum(a);
void IncorrectNum(string number)
{
    if (number?.Length<3)
    {
        Console.WriteLine("У числа нет третьей цифры");
    }
    else
    {
        Console.WriteLine(number[2]);
    }
}
