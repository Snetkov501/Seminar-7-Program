// Task 47


Console.Clear();
Console.WriteLine("Задайте количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] twoDimArray = new double[m, n];
Random rnd = new Random();

void PrintArray(double [,] matrix)
{ 
    for (int i = 0; i < m; i++)
    { 
        for (int j = 0; j < n; j++)
        { 
            Console.Write($" {matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matrix)
{ 
    for (int i = 0; i < m; i++)
    { 
        for (int j = 0; j < n; j++)
        { 
            matrix [i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);
        }
    }
}
FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);