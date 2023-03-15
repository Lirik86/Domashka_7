int input(string msg)
{
    System.Console.WriteLine($"{msg} >");
    int value;
    if(int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

int[,] myArray(int col, int row)
{
    int[,] array = new int[col,row];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,10);
        }
    }
    return array;
}
double SrAr(int[,] array, int col)
{
    double SredArph = 0;
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = array[i,j] + sum;
        }
        SredArph = sum/col;
        sum = 0;
        System.Console.WriteLine($"Среднее арифмитическое {j+1} столбца равно {SredArph:F2} ");
    }
    return SredArph;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]}\t");
        }
    }
    System.Console.WriteLine();
}

int row = input("Введите кол-во строк в массиве: ");
int col = input("Введите кол-во столбцов в массиве: ");
int[,] array = myArray(col, row);
PrintArray(array);
double SredArh = SrAr(array, col);
