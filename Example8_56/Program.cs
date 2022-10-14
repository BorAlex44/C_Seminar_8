using static System.Console;
Clear();
Write("Введите размер матрицы, минимальное и максимальное значение елементов матрицы через пробел: ");
int[] parameters = GetArrayInString(ReadLine()!);
int[,] MyMatrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(MyMatrix);
WriteLine();
WriteLine($"Строка с наименьшей суммой элементов - {GetMinSumRow(MyMatrix)}");








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

int GetMinSumRow(int[,] newArray)
{
    int minRow = 0;
    int minSumma = 0;
    for (int i = 0; i < newArray.GetLength(1); i++)
    {
        minSumma = minSumma + newArray[0, i];
    }
    for (int i = 1; i < newArray.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            summa = summa + newArray[i, j];
            if (minSumma > summa)
            {
                minSumma = summa;
                minRow = i;
            }
        }
    }
    return minRow;
}