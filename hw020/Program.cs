// Задача 50. Напишите программу, которая на вход принимает число
// и ищет в двумерном массиве, и возвращает индексы этого элемента
// или же указание, что такого элемента нет.

Console.Clear();

Random rnd = new Random();
int m = rnd.Next(2, 6);
int n = rnd.Next(2, 6);
int searchNumber = rnd.Next(-10, 11);

int[,] randomArray = CreateRandomMatrix(m, n);
int[] searchIndex = SearchNumber(randomArray);
WriteMatrix(randomArray);

Console.WriteLine("Ищем число {0}", searchNumber);
if (searchIndex[0] == -1)
{
    Console.WriteLine("Такого числа в массиве нет!");
}
else
{
    Console.WriteLine("Искомое число найдено в элементе [{0},{1}]", searchIndex[0], searchIndex[1]);
}

int[] SearchNumber(int[,] array)
{
    int[] indexArray = new int[] { -1, -1 };
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == searchNumber)
            {
                indexArray[0] = i;
                indexArray[1] = j;
                return indexArray;
            }
        }
    }
    return indexArray;
}

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

void WriteMatrix(int[,] array)
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
                x += 4;
            }
            else
            {
                Console.SetCursorPosition(x, y);
                Console.Write(array[i, j]);
                x += 5;
            }
        }
        y++;
    }
    Console.WriteLine();
}