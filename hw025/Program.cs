// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных 
// чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

int[,,] matrix3D = CreateMatrix3D();

FillMatrix3D(matrix3D);
WriteMatrix3D(matrix3D);

int[,,] CreateMatrix3D()
{
    int columns, rows, layers, volume;
    do
    {
        Console.Clear();
        Console.WriteLine("Введите размерность трехмерного массива:");
        Console.WriteLine("(объем массива не должен превшать 90 элементов)");
        Console.Write($"--столбцов (max = 22): ");
            columns = GetValidLength();
        int maxRows = 90 / columns / 2;
        Console.WriteLine("|\\");
        Console.Write($"| \\строк (max = {maxRows}): ");
            rows = GetValidLength();
        int maxLayers = 90 / columns / rows;
        Console.WriteLine("|");
        Console.Write($"слоёв (max = {maxLayers}): ");
            layers = GetValidLength();
        volume = rows * columns * layers;
    } while (volume > 90);
    return matrix3D = new int[rows, columns, layers];
}

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

void FillMatrix3D(int[,,] inMatrix3D)
{
    Random rnd = new Random();
    for (int layer = 0; layer < inMatrix3D.GetLength(2); layer++)
    {
        for (int row = 0; row < inMatrix3D.GetLength(0); row++)
        {
            for (int column = 0; column < inMatrix3D.GetLength(1); column++)
            {
                int element = rnd.Next(10, 100);
                while (CheckDoubleElement(inMatrix3D, element))
                {
                    element = rnd.Next(10, 100);
                }
                inMatrix3D[row, column, layer] = element;
            }
        }
    }
}

bool CheckDoubleElement(int[,,] inMatrix3D, int number)
{
    for (int i = 0; i < inMatrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < inMatrix3D.GetLength(2); k++)
            {
                if (inMatrix3D[i, j, k] == number)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

void WriteMatrix3D(int[,,] inMatrix)
{
    Console.WriteLine();
    for (int layer = 0; layer < inMatrix.GetLength(2); layer++)
    {
        for (int row = 0; row < inMatrix.GetLength(0); row++)
        {
            for (int column = 0; column < inMatrix.GetLength(1); column++)
            {
                // Console.Write(inMatrix[row, column, layer] + " ");
                Console.Write($"{inMatrix[row, column, layer]}({layer},{row},{column}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
