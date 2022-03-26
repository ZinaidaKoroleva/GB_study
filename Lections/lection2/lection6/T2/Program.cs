// See https://aka.ms/new-console-template for more information
int Factoriaj(int n)
{
    if(n==1) return 1;
    else return n * Factoriaj(n-1);
}
for (int i=1;i<40; i++)
{
 Console.WriteLine(Factoriaj(i));   
}
