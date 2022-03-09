//Задача 19: Напишите программу, 
//которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int num= number;
int[] mass=new int[5];
mass[0]=number%10;
for (int i=0;i<5; ++i)
{
    mass[i]=number%10;
    number=number/10;
}
int number2=mass[0]*10000+mass[1]*1000+mass[2]*100+mass[3]*10+mass[4];
if (number2==num)
{
    Console.WriteLine("Число " + num + " является палиндромом!");
}
else
{
   Console.WriteLine("Число " + num + " не является палиндромом!"); 
}