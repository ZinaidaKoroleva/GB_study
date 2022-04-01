// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите десятичное число");
int number = Convert.ToInt32(Console.ReadLine());
DvCod(number);
void DvCod(int number)
{
    int num = number;
    string DvFigural = "";
    while (number >= 1)
    {
        DvFigural = Convert.ToString(number % 2) + DvFigural;
        number = number/2;
    }
    Console.Write($"Число {num} в десятичном виде равно {DvFigural}");
}