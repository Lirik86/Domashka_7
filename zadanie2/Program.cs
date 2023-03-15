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

int[,] myArray(int row, int col)
{
    int[,] array = new int[row,col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(-9,10);
        }
    }
    return array;
}
void PrintArray(int[,] array, int index1, int index2)
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if(i == index1 && j == index2)
            {
                System.Console.Write($"Элемент с индексом [{index1}, {index2}] равен {array[i,j]}");
            }
            else
            {
                System.Console.WriteLine("Такого элемента не существует в массиве!");
                return;
            }
        }
    }

}

int row = input("Введите кол-во строк в массиве: ");
int cow = input("Введите кол-во столбцов в массиве: ");
int[,] array = myArray(row, cow);
int index1 = input("Введите первый индекс искомого элемента в двумерном массиве: ");
int index2 = input("Введите второй индекс искомого элемента в двумерном массиве: ");
PrintArray(array, index1, index2);