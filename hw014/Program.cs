// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.

int evenNumbers = CalcEvenNumbers(FillRandArray(GetValidLength()));
Console.WriteLine($"Количество четных элементов массива: {evenNumbers}");

int CalcEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] FillRandArray(int length)
{
    Random rnd = new Random();
    int[] array = new int[length];
    Console.Write("[");
    for (int i = 0; i < length - 1; i++)
    {
        array[i] = rnd.Next(100, 1000);
        Console.Write($"{array[i]}, ");
    }
    array[length - 1] = rnd.Next(100, 1000);
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