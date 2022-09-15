// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int rows = GetValidLength();
Console.Write("Введите количество столбцов двумерного массива: ");
int columns = GetValidLength();
int[,] matrixOne = GetRandomMatrix(rows, columns);
int[,] matrixTwo = GetRandomMatrix(columns, rows);
int[,] resaltMatrix = MultiplicationMatrices(matrixOne, matrixTwo);

Console.WriteLine("Произведение двумерных матриц");
WriteMatrix(matrixOne);
Console.WriteLine("умножаем на");
WriteMatrix(matrixTwo);
Console.WriteLine("Результат");
WriteMatrix(resaltMatrix);

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
            if(inMatrix[i, j] < 100)
            {
                Console.Write(" ");
            }
            Console.Write(inMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }    
}

int[,] MultiplicationMatrices(int[,] inMatrix1, int[,] inMatrix2)
{
    int[,] multiMatrix = new int[inMatrix1.GetLength(0), inMatrix1.GetLength(0)];
    int[] resalt = new int[inMatrix1.GetLength(0)];
    for (int i = 0; i < inMatrix1.GetLength(0); i++)
    {
        for (int j = 0; j < multiMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inMatrix1.GetLength(1); k++)
            {
                multiMatrix[i, j] += inMatrix1[i, k] * inMatrix2[k, j];    
            }
            
        }
    }    
    return multiMatrix;
}
