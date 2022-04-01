// See https://aka.ms/new-console-template for more information
double a = 0;
double b = 1;
double number = 0;
int n=100;
int i = 0;
while (i<n)
{
    number = a+b;
    Console.WriteLine(number);
    a = b;
    b = number;
    i++;
}
