using static System.Console;
Clear();
Write("Введите параметры трехмерного массива i,j,k через пробелл: ");
string[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,,] MyMatrix = GetMatrixArray(new int[] { int.Parse(parameters[0]), int.Parse(parameters[1]),
int.Parse(parameters[2])}, 10, 99);
PrintMatrix(MyMatrix);







int[,,] GetMatrixArray(int[] parametr, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,,] resultMatrix = new int[parametr[0], parametr[1], parametr[2]];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < resultMatrix.GetLength(2); k++)
            {
                int number = rnd.Next(minValue, maxValue + 1);
                if (GetuniqueNumber(resultMatrix, number)) continue;
                resultMatrix[i, j, k] = number;
            }
        }
    }
    return resultMatrix;
}

bool GetuniqueNumber(int[,,] newMatrix, int num)
{
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < newMatrix.GetLength(2); k++)
            {
                if (newMatrix[i, j, k] == num) return true;
            }
        }
    }
    return false;
}

void PrintMatrix(int[,,] MyMatrix)
{
    for (int i = 0; i < MyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < MyMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < MyMatrix.GetLength(2); k++)
            {
                Write($"{MyMatrix[i, j, k]} ({i},{j},{k})\t");
            }
            WriteLine();
        }
    }
}