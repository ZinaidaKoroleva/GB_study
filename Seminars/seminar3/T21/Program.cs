Random rand = new Random();
int a_x = rand.Next(1,10);
int a_y = rand.Next(1,10);
int b_x = rand.Next(1,10);
int b_y = rand.Next(1,10);
Console.WriteLine("Точка A - " + a_x + ":" + a_y);
Console.WriteLine("Точка B - " + b_x + ":" + b_y);
double rasst = Math.Pow((a_x - b_x), 2);
//Math.Sqrt((a_x-b_x)*(a_x-b_x)+(a_y-b_y)*(a_y-b_y))
Console.WriteLine("Длина отрезка: " + rasst);
