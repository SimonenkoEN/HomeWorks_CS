// Задача 27: Напишите программу, которая принимает на вход
// число и выдаёт сумму цифр в числе.

int a = GetValidNumber();
Console.WriteLine(GetSumDigits1(a));
Console.WriteLine(GetSumDigits2(a));

int GetValidNumber()
{
    Console.Write("Введите число: ");
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    while (!isNum)
    {
        Console.Write("Неверное значение! Повторите ввод: ");
        isNum = int.TryParse(Console.ReadLine(), out num);
    }
    return num;
}

int GetSumDigits1(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int GetSumDigits2(int number)
{
    int sum = 0;
    string str = number.ToString();
    if (str.Substring(0, 1).Equals("-"))
    {
        for (int i = 1; i < str.Length; i++)
        {
            sum += Convert.ToInt32(str.Substring(i, 1)) * -1;            
        }        
    }
    else
    {
        for (int i = 0; i < str.Length; i++)
        {
            sum += Convert.ToInt32(str.Substring(i, 1));
        }
    }
    return sum;
}