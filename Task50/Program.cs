//  Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же 
// указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Write("Enter amount of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter amount of columns: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] mat = FillMatrix(row, col, -10, 10);
PrintMatrix(mat);
ElementSearch(mat);

Console.Write("Enter a number you want to search: ");
int num = Convert.ToInt32(Console.ReadLine());

int countSearchingNumber = Count(mat, num);
PositionSearch(mat, num, countSearchingNumber);


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

void ElementSearch(int[,] matrix)
{
    Console.Write("Enter the number of row: ");
    int rowNum = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the number of column: ");
    int colNum = Convert.ToInt32(Console.ReadLine());
    if (rowNum > row || colNum > col)
    {
        Console.WriteLine("There is no such element");
    }
    else
    {
        Console.WriteLine($"The number in the postion ({rowNum}, {colNum}) is {mat[rowNum, colNum]}.");
    }
}

int Count(int[,] matrix, int num)
{
    int count = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (matrix[i, j] == num)
            {
                count += 1;
            }

        }
    }
    return count;
}

void PositionSearch(int[,] matrix, int num, int count)
{
    if (count == 0)
    {
        Console.WriteLine($"There is no '{num}' in the table.");
    }
    else
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (matrix[i, j] == num)
                {
                    Console.WriteLine($"There is number '{num}' in the position ({i}, {j}).");
                }
            }
        }
    }

}