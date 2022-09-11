// Задача 19. Напишите программу, которая принимает на вход
// целое число и проверяет, является ли оно палиндромом.

Console.Write("Введите целое число: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int num);

if (isNumber)
{
    if (CheckPalyndrom(num))
    {
        Console.WriteLine("Введенное число палиндром!");
    }
    else
    {
        Console.WriteLine("Введенное число не палиндром!");
    }
}
else
{
    Console.WriteLine("Ошибка ввода!");
}

bool CheckPalyndrom(int number)
{
    bool isPaly = true;
    string str = number.ToString();

    for (int i = 0; i < (str.Length - 1) / 2; i++)
    {
        if (str[i] != str[str.Length - 1 - i])
        {
            isPaly = false;
            break;
        }
    }

    if (number < 0 || number >= 10 && number <= 99 && str[0] != str[1])
    {
        return false;
    }
    
    return isPaly;
}