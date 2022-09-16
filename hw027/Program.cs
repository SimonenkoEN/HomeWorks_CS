// Задача 64: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

Console.Clear();
Console.Write("Введите натуральные числа:\nM =  ");
int m = GetValidNumber();
Console.Write("N = ");
int n = GetValidNumber(m);Console.Write($"Натуральные числа от {m} до {n}: ");
Console.WriteLine(WriteNaturalNumbers(m, n));

string WriteNaturalNumbers(int a, int b, string str = "")
{
    if (a <= b)
    {
        str += a;
        return WriteNaturalNumbers(a + 1, b, str + " ");
    }
    return str;
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
