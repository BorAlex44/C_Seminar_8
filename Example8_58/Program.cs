using static System.Console;
Clear();
Write("Введите размер 1 матрицы, минимальное и максимальное значение елементов 1 матрицы через пробел: ");
int[] parameters1 = GetArrayInString(ReadLine()!);
int[,] MyMatrix1 = GetMatrixArray(parameters1[0], parameters1[1], parameters1[2], parameters1[3]);
PrintMatrix(MyMatrix1);
Write("Введите размер 2 матрицы, минимальное и максимальное значение елементов 2 матрицы через пробел: ");
int[] parameters2 = GetArrayInString(ReadLine()!);
int[,] MyMatrix2 = GetMatrixArray(parameters2[0], parameters2[1], parameters2[2], parameters2[3]);
PrintMatrix(MyMatrix2);
int[,] MyMatrix3 = GetMultiplicationMatrix(MyMatrix1, MyMatrix2);
WriteLine($"При умножении одной 1 матрицы на вторую получим матрицу");
PrintMatrix(MyMatrix3);




int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return resultMatrix;
}


void PrintMatrix(int[,] newMatrix)
{
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            Write($"{newMatrix[i, j]}\t");
        }
        WriteLine();
    }
}


int[] GetArrayInString(string parameters)
{
    string[] parametr = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] parametrNum = new int[parametr.Length];
    for (int i = 0; i < parametrNum.Length; i++)
    {
        parametrNum[i] = int.Parse(parametr[i]);
    }
    return parametrNum;
}

int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayC;
}

