// Задача 62. Напишите программу, которая заполнит спирально массив n на n.

Console.Clear();
Console.Write("Введите размерность двумерной матрицы: ");
int rowsXcolumns = GetValidLength();
int element = 1;
int startLine = 0, endLine = rowsXcolumns - 1;
int startPos = 0, endPos = rowsXcolumns - 1;
int[,] matrix = new int[rowsXcolumns, rowsXcolumns];

FillMatrix(matrix);
WriteMatrix(matrix);

int GetValidLength() {
    bool isNumber = int.TryParse(Console.ReadLine(), out int number);
    while (number < 1) {
        Console.Write("Введите положительное числовое значение: ");
        isNumber = int.TryParse(Console.ReadLine(), out number);
    }
    return number;
}

void FillMatrix(int[,] inMatrix) {
    int count = 0;
    for (count = 0; count <= rowsXcolumns - 1; count++) {
        if (count % 2 == 0) {
            FillLeftDown(inMatrix);
        }
        else {
            FillRightUp(inMatrix);
        }
    }
}

void FillLeftDown(int[,] inMatrix) {
    for (int fillCol = startPos; fillCol <= endPos; fillCol++) {
        inMatrix[startLine, fillCol] = element;
        element++;        
    }
    startLine++;
    for (int fillRow = startLine; fillRow <= endLine; fillRow++) {
        inMatrix[fillRow, endPos] = element;
        element++;
    }
    endPos--;
}

void FillRightUp(int[,] inMatrix) {
    for (int fillCol = endPos; fillCol >= startPos; fillCol--) {
        inMatrix[endLine, fillCol] = element;
        element++;        
    }
    endLine--;
    for (int fillRow = endLine; fillRow >= startLine; fillRow--) {
        inMatrix[fillRow, startPos] = element;
        element++;
    }
    startPos++;
}

void WriteMatrix(int[,] inMatrix) {
    for (int i = 0; i < inMatrix.GetLength(0); i++) {
        for (int j = 0; j < inMatrix.GetLength(1); j++) {
            if (inMatrix[i, j] < 10) {
                Console.Write(0);
            }
            Console.Write(+ inMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
