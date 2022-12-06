// Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.
//m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


    Console.Write("Enter amount of rows: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter amount of columns: ");
    int col = Convert.ToInt32(Console.ReadLine());

    PrintMatrix(FillMatrix(row, col, -10, 10));

double[,] FillMatrix(int row, int col, int min, int max)
{
    double[,] matrix = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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
