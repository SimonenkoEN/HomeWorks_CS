// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int rows = GetValidLength();
Console.Write("Введите количество столбцов двумерного массива: ");
int columns = GetValidLength();
int[,] matrix = GetRandomMatrix(rows, columns);

WriteMatrix(matrix);
SortRowsDescendingOrder(matrix);
Console.WriteLine("Двумерный массив со строками отсортированными по убыванию");
WriteMatrix(matrix);

int GetValidLength()
{
    bool isNumber = int.TryParse(Console.ReadLine(), out int number);
    while (number < 1)
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
            outMatrix[i, j] = rnd.Next(10, 99);
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

void SortRowsDescendingOrder(int[,] inMatrix)
{
    int tmp;
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < inMatrix.GetLength(1) - 1 - j; k++)
            {
                if (inMatrix[i, k] < inMatrix[i, k + 1])
                {
                    tmp = inMatrix[i, k + 1];
                    inMatrix[i, k + 1] = inMatrix[i, k];
                    inMatrix[i, k] = tmp;
                }
            }
        }
    }
}
