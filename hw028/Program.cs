// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N.

Console.Clear();
Console.Write("Введите натуральные числа:\nM =  ");
int m = GetValidNumber();
Console.Write("N = ");
int n = GetValidNumber(m);
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} раына {GetSumNaturalNumbers(m, n)}");

int GetSumNaturalNumbers(int a, int b, int res = 0)
{
    if (a <= b)
    {
        res += a;
        return GetSumNaturalNumbers(a + 1, b, res);
    }
    return res;
}

int GetValidNumber(int a = 0)
{
    bool isNumber = int.TryParse(Console.ReadLine(), out int number);
    while (number <= a)
    {
        Console.Write($"Введите натуральное числово > {a}: ");
        isNumber = int.TryParse(Console.ReadLine(), out number);
    }
    return number;
}
