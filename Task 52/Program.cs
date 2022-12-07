// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Enter amount of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter amount of columns: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] mat = FillMatrix(row, col, -10, 10);
PrintMatrix(mat);

PrintArray(MeanOfColumn(mat, row, col), col);

int[,] FillMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 20);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] MeanOfColumn(int[,] matrix, int row, int col)
{
    double[] result = new double[col];
    for (int i = 0; i < col; i++)
    {
        
        double sum = 0;
        double mean = 0;
        for (int j = 0; j < row; j++)
        {
            sum += mat[j, i];

        }
        mean = Math.Round((sum / row), 2);
        result[i] = mean;
        
    }
    return result;
}


void PrintArray(double[] array, int col)
{
    for (int i = 0; i < col; i++)
    {
        if (i == col - 1)
        {
            Console.WriteLine($"{array[i]}");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
}
