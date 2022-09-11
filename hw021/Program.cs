// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
int x = 0, y = 0;

Random rnd = new Random();
int m = rnd.Next(2, 6);
int n = rnd.Next(2, 6);

int[,] randomArray = CreateRandomMatrix(m, n);
double[] arithmeticMeanColumns = ArithmeticMeans(randomArray);
WriteMatrix(randomArray);
WriteArray(arithmeticMeanColumns);

int[,] CreateRandomMatrix(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 11);
        }
    }
    return array;
}

double[] ArithmeticMeans(int[,] array)
{
    double[] arrayAM = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        arrayAM[i] = Math.Round(sum / array.GetLength(0), 2);
    }
    return arrayAM;
}

void WriteMatrix(int[,] array)
{    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        x = 0;
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
    Console.WriteLine();
}

void WriteArray(double[] array)
{
    x = 0;
    Console.WriteLine("Среднее арифметическое");
    foreach (double el in array)
    {
         if (el >= 0)
            {
                x++;
                Console.SetCursorPosition(x, y + 1);
                Console.Write(el);
                x += 5;
            }
            else
            {
                Console.SetCursorPosition(x, y + 1);
                Console.Write(el);
                x += 6;
            }
    }
}