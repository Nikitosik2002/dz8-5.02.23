System.Console.WriteLine("Введите количество строк и столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[n,n];
int[,] matrix2 = new int[n,n];




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

fillMatrix(matrix1);
fillMatrix(matrix2);

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

printMatrix(matrix1);
System.Console.WriteLine("-------");
printMatrix(matrix2);

int [,] multiplicationMatrix(int[,] matrix1, int[,] matrix2)
{

    int[,] multiMatrix = new int [matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            multiMatrix[i,j] = 0;

            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                multiMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return multiMatrix;
}

System.Console.WriteLine("-------");
printMatrix(multiplicationMatrix(matrix1,matrix2));
