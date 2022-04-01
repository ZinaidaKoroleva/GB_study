// Задача 40: Напишите программу,которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник со сторонами такой длины
Console.WriteLine("Введите первую сторону");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b+c && b < a+c && c < b+a) Console.WriteLine("Треугольник существует");
else Console.WriteLine("Треугольник не существует");