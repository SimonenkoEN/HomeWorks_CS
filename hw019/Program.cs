// Задача 47. Задайте двумерный массив размером m?n,
// заполненный случайными вещественными числами.

Console.Clear();

Random rnd = new Random();
int m = rnd.Next(2, 6);
int n = rnd.Next(2, 6);

WriteMatrix(CreateDoubleMatrix(m, n));

double[,] CreateDoubleMatrix(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double tmp = rnd.Next(-99, 1000);
            array[i, j] = tmp / 10;
        }
    }
    return array;
}

void WriteMatrix(double[,] array)
{    
    int y = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int x = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 0)
            {
                x++;
                Console.SetCursorPosition(x, y);
                Console.Write(array[i, j]);
                x += 5;
            }
            else
            {
                Console.SetCursorPosition(x, y);
                Console.Write(array[i, j]);
                x += 6;
            }
        }
        y++;
    }
}