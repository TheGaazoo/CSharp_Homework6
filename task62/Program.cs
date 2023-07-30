int n = 4;
int[,] squareMatrix = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;
while (temp <= squareMatrix.GetLength(0) * squareMatrix.GetLength(1))
{
    squareMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < squareMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= squareMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > squareMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}
Console.WriteLine("Заполняем спирально массив:");
WriteArray(squareMatrix);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} \t");

            else Console.Write($"{array[i, j]} \t");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}
