// Напишите программу, которая на вход принимает два числа и выдает первые N чисел, 
//для которых каждое следующее равно сумме двух предыдущих.
int startNumber = 3;
int finishNumber = 4;
int count = 5;
Recursion(startNumber, finishNumber, count);
void Recursion(int n, int m, int temp)
{
    if (temp == 0) return;
    else
    {
        Console.Write(n + " ");
        int buff = n;
        n += m;
        m = buff;
        Recursion(n, m, --temp);
    }
}

