double[,] myArray(int row, int col)
{
    double[,] array = new double[row,col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(-9,10);
            array[i,j] = array[i,j] + rnd.NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]:F2}\t");
        }
    }
    System.Console.WriteLine();
}

double[,] matrix = myArray(3,4);
PrintArray(matrix);
