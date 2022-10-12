using static System.Console;
Clear();
Write("Введите размер матрицы, минимальное и максимальное значение елементов матрицы через пробел: ");
int[] parameters = GetArrayInString(ReadLine()!);
int[,] MyMatrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(MyMatrix);
GetSortArrey(MyMatrix);
WriteLine();
PrintMatrix(MyMatrix);















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


void GetSortArrey(int[,] noSortMatrix)
{
    for (int i = 0; i < noSortMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < noSortMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < noSortMatrix.GetLength(1) - 1; k++)
            {
                if (noSortMatrix[i, k] < noSortMatrix[i, k + 1])
                {
                    int temp = noSortMatrix[i, k + 1];
                    noSortMatrix[i, k + 1] = noSortMatrix[i, k];
                    noSortMatrix[i, k] = temp;
                }
            }
        }

    }
}