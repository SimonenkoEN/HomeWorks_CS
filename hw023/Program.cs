// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int rows = GetValidLength();
Console.Write("Введите количество столбцов двумерного массива: ");
int columns = GetValidLength();
int[,] matrix = GetRandomMatrix(rows, columns);
int[] array = FindMinSumRow(matrix);

WriteMatrix(matrix);
Console.WriteLine($"Минимальная сумма {array[0]} в {array[1]} строке.");

int GetValidLength()
{
    bool isNumber = int.TryParse(Console.ReadLine(), out int number);
    while(number < 1)
    {
        Console.Write("Введите положительное числовое значение: ");
        isNumber = int.TryParse(Console.ReadLine(), out number);
    }
    return number;
}

int[,] GetRandomMatrix(int rows, int columns)
{
    Random rnd = new Random();
    int[,] outMatrix = new int[rows, columns];
    for (int i = 0; i < outMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < outMatrix.GetLength(1); j++)
        {
            outMatrix[i, j] = rnd.Next(9);
        }
    }
    return outMatrix;
}

void WriteMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {        
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Console.Write(inMatrix[i, j] + "  ");
        }
        Console.WriteLine();
    }    
}

int[] FindMinSumRow(int[,] inMatrix)
{    
    int[] minSum = new int[2];
    int sum = 0;
    minSum[0] = FindSumRow(inMatrix, 0);
    minSum[1] = 1;
    for (int i = 1; i < inMatrix.GetLength(0); i++)
    {        
        sum = FindSumRow(inMatrix, i);
        if (minSum[0] > sum)
        {
            minSum[0] = sum;
            minSum[1] = i + 1;
        }
    }
    return minSum;
}

int FindSumRow(int[,] inMatrix, int line)
{
    int sum = 0;
    for (int i = 0; i < inMatrix.GetLength(1); i++)
    {
        sum += inMatrix[line, i];
    }
    return sum;
}
