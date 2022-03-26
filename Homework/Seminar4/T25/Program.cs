// Задача 25: Напишите цикл, который принимает на вход два натуральных числа (A и B) 
// и возводит число A в степень B.
Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Degree());
int Degree ()
{
    int c = 1;
for (int i = 1; i <= B; i ++)
{
    c = c*A;
}
return c;
}