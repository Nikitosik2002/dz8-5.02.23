System.Console.WriteLine("Введите количество строк и столбцов матрицы");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n,n];
int[,] newMatrix = new int[n,n];

void fillMatrix (int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(9);
    }
}
}
fillMatrix(matrix);

void printMatrix (int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        System.Console.Write(matrix[i,j] + " ");
    }
    System.Console.WriteLine();
}
}
printMatrix(matrix);


int max = matrix[0,0];
int line = 0;
int column = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i,j] > max)
        {
            max = matrix[i,j];
            line = i;
            column = j;
        }
    }
    
}

System.Console.WriteLine("Максиальное число матрицы = " + max);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        
        if(i == line || j == column)  matrix[i,j] = 0;
    }
    
}

System.Console.WriteLine();
printMatrix(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       if (i != line || j != column) newMatrix[i,j] = matrix[i,j];
    }
}

System.Console.WriteLine();

printMatrix(newMatrix);