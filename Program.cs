void FillMatrix(int [,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
        mat[i, j] = new Random().Next(1, 10);
        }
    }
}

// int [,] matrix = new int [3, 4];
// int [,] matrix = Input
// PrintMatrix(matrix);
// Console.WriteLine();
