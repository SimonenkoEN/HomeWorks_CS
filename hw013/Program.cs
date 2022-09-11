// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.

WriteArray(GetArray(GetValidLength()));

int GetValidNumber()
{
    bool isNumber = int.TryParse(Console.ReadLine(), out int number);

    if (!isNumber)
    {
        Console.Write("Введена неверное значение! Повторите ввод: ");
        number = GetValidNumber();
    }
    return number;
}

int GetValidLength()
{
    Console.Write("Введите длину массива: ");
    bool isCheck = int.TryParse(Console.ReadLine(), out int length);
    while (length < 1)
    {
        Console.Write("Введена неверное значение! Повторите ввод: ");
        isCheck = int.TryParse(Console.ReadLine(), out length);
    }
    return length;
}

int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array[i] = GetValidNumber();
    }
    return array;
}

void WriteArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}