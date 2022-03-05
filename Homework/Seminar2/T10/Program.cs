//Задача 10
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
Reverse();  
void Reverse() 
{
int a = number/100;
int b = number%100/10;
int c = number%10;
Console.WriteLine(c*100+b*10+a);
}