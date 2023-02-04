// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите первое число ");
int n = Convert.ToInt32(Console.ReadLine() ?? "");
Console.WriteLine("Введите второе число ");
int m = Convert.ToInt32(Console.ReadLine() ?? "");
if (m==n) Console.WriteLine("Числа равны");
else if (n>m)
{
    int k=m;
    m=n;
    n=k;
} 
Numbers(n,m);
void Numbers(int n, int m)
{
    Console.Write($"Сумма = {SumNum(n - 1, m)} ");
}
int SumNum(int n, int m)
{
    int p = n;
    if (n==m) return 0;
    else
    { 
        n++;
        p = n + SumNum(n, m);
        return p;
    }
}
