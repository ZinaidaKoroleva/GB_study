// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double b1 = 1;
double k1 = 0;
double b2 = -1;
double k2 = 2;
if (k1==k2) Console.WriteLine("Прямые параллельны");
else
{
    double x = (b2 - b1)/(k1-k2);
    double y = k1*x + b1; // int y = k2*x + b2;
    Console.WriteLine("Координата х: " + x);
    Console.WriteLine("Координата y: " + y);
}
