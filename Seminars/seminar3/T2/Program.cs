Console.WriteLine("Введите координаты");
int[] mass = new int[2];
mass[0]=Convert.ToInt32(Console.ReadLine());
mass[1] = Convert.ToInt32(Console.ReadLine());
PointCheck(mass[0],mass[1]);
void PointCheck(int x, int y)
{
if (x>0 && y>0)
{
    Console.WriteLine("Точка лежит в первой четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка лежит в четвертой четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка лежит в третьей четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка лежит во второй четверти");
}
else
{
Console.WriteLine("Введены неправильные данные");
}
}