// Задача 25: Напишите цикл, который принимает на вход два натуральных числа (A и B) 
// и возводит число A в степень B.
Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Degree());
int Degree ()
{
for (int i = 1; i <= B; i ++)
{
    A = A*A;
}
return A;
}