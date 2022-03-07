// Дополнительная задача 1
Console.WriteLine("Введите длину первой стороны треугольника");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны треугольника");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны треугольника");
int c = Convert.ToInt32(Console.ReadLine());
if ((a>=c+b) || (b>=a+c) || (c>=a+b))
{
 Console.WriteLine("Такого треугольника не существует");    
}
else 
{
   if ((a==b) || (a==c) || (c==b))
    {
        Console.WriteLine("Треугольник равнобедренный"); 
    }
    else 
    
        Console.WriteLine("Треугольник не равнобедренный"); 
}
 
