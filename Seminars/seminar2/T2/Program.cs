string s = Console.ReadLine();
while (s.Length !=3)
{
    System.Console.WriteLine("Вы ввели не трехзначное число, введите заново");
 s=Console.ReadLine();   
}

System.Console.WriteLine(s[1]);
