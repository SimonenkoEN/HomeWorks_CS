// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
//
//          ⎧n + 1                  m = 0
// A(m,n) = ⎨A(m - 1, 1)            m > 0, n = 0
//          ⎩A(m - 1,A(m, n - 1))   m > 0, n > 0

Console.Clear();

Random rnd = new Random();
int m = rnd.Next(0, 4);
int n = rnd.Next(0, 11);
Console.WriteLine($"Функция Аккермана:\nA({m}, {n}) = {CalcFuncionAkkerman(m, n)}");

int CalcFuncionAkkerman(int mAkkerman, int nAkkerman)
{
    if (mAkkerman == 0)
    {
        return nAkkerman + 1;

    }
    else if (mAkkerman > 0 && nAkkerman == 0)
    {
        return CalcFuncionAkkerman(mAkkerman - 1, 1);
    }
    else if (mAkkerman > 0 && nAkkerman > 0)
    {
        return CalcFuncionAkkerman(mAkkerman - 1, CalcFuncionAkkerman(mAkkerman, nAkkerman - 1));
    }
    return CalcFuncionAkkerman(mAkkerman, nAkkerman);
}
