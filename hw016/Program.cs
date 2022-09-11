// Задача 38: Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Для заполнения массива");
int lengthArr = GetValidLength();
double[] arr = FillArray(lengthArr);

double minValue = arr[FoundMinPos(arr)];
double maxValue = arr[FoundMaxPos(arr)];

Console.Write("Разница между макс и мин элементами массива: ");
Console.WriteLine(maxValue - minValue);

double[] FillArray(int length)
{
    double[] array = new double[length];
    
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array[i] = GetValidNumber();
    }
    
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");

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

double GetValidNumber()
{
    bool isNumber = double.TryParse(Console.ReadLine(), out double number);
    while(!isNumber)
    {
        Console.Write("Введено неверное значение! Попробуйте еще раз: ");
        isNumber = double.TryParse(Console.ReadLine(), out number);
    }
    return number;
}

int FoundMinPos(double[] array)
{
    int min = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[min])
        {
            min = i;
        }
    }
    return min;
}

int FoundMaxPos(double[] array)
{
    int max = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[max])
        {
            max = i;
        }
    }
    return max;
}