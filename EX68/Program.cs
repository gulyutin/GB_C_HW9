// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Write("Введи M: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи N: ");
int n = Convert.ToInt16(Console.ReadLine());
A(n, m);
            
static int A(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return A(n - 1, 1);
    if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
    return A(n,m);
}
Console.WriteLine(A(n,m));