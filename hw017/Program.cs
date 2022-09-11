// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.WriteLine($"Введено чисел больше 0: {CountPositivNumbers(GetNumbers())}");

int CountPositivNumbers(List<int> lists)
{
    int count = 0;
    foreach (int el in lists)
    {
        if (el > 0)
        {
            Console.Write($"{el} ");
            count++;
        }
    }
    Console.WriteLine();
    return count;
}

List<int> GetNumbers()
{
    int count = 1;
    Console.WriteLine("Введите целые числа (для завершения - любое нечисловое значение): ");
    List<int> numbers = new List<int>();
    bool isNumber = true;
    while (isNumber)
    {
        Console.Write($"{count}) ");
        isNumber = int.TryParse(Console.ReadLine(), out int number);
        numbers.Add(number);
        count++;        
    }
    Console.SetCursorPosition(0, count-1);
    return numbers ;
}