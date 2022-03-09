// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты первой точки");
int a_x = Convert.ToInt32(Console.ReadLine());
int a_y = Convert.ToInt32(Console.ReadLine());
int a_z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
int b_x = Convert.ToInt32(Console.ReadLine());
int b_y = Convert.ToInt32(Console.ReadLine());
int b_z = Convert.ToInt32(Console.ReadLine());
double rasst= Math.Sqrt((Math.Pow((a_x-b_x),2))+ (Math.Pow((a_y-b_y),2))+(Math.Pow((a_z-b_z),2)));
//double rasst= Math.Sqrt((a_x-b_x)*(a_x-b_x)+(a_y-b_y)*(a_y-b_y)+(a_z-b_z)*(a_z-b_z)); Это другая форма записи
Console.WriteLine("Расстояние между точками равно: "+ rasst);
