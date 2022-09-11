// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Для заполнения массива");
int length = GetValidLength();
Console.Write("Введите начальное значение диапазона случайных чисел: ");
int minRange = GetValidNumber();
Console.Write("Введите конечное значение диапазона случайных чисел: ");
int maxRange = GetValidNumber();

int sumOddPos = GetSumOddPositions(FillRandArray(length, minRange, maxRange));
Console.Write($"Сумма элементов массива с нечетными индексами: {sumOddPos}");

int GetSumOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int[] FillRandArray(int length, int beginRange, int endRange)
{
    Random rnd = new Random();
    int[] array = new int[length];
    Console.Write("[");
    for (int i = 0; i < length - 1; i++)
    {
        array[i] = rnd.Next(beginRange, endRange + 1);
        Console.Write($"{array[i]}, ");
    }
    array[length - 1] = rnd.Next(beginRange, endRange + 1);
    Console.WriteLine($"{array[length - 1]}]");
    return array;
}

int GetValidLength()
{
    Console.Write("Введите количество элементов массива: ");
    bool isLength = int.TryParse(Console.ReadLine(), out int length);
    while(length < 1)
    {
        Console.Write("Введено неверное значение! Попробуйте еще раз: ");
        isLength = int.TryParse(Console.ReadLine(), out length);
    }
    return length;
}

int GetValidNumber()
{
    bool isNumber = int.TryParse(Console.ReadLine(), out int number);
    while(!isNumber)
    {
        Console.Write("Введено неверное значение! Попробуйте еще раз: ");
        isNumber = int.TryParse(Console.ReadLine(), out number);
    }
    return number;
}