int[,] matrix = new int[5,5];

System.Console.WriteLine("Введите максимальное число массива");

int n = Convert.ToInt32(Console.ReadLine());

void fillArr (int[,] matrix, int n)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(n);
        System.Console.Write(matrix[i,j] + " ");
    }
    System.Console.WriteLine();
   }
}
fillArr(matrix, n);
System.Console.WriteLine();

for (int i = 0; i < n; i++)
{
    int number = i;
    int count = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
             if (matrix[j,k] == number)
        {
            count++;
        }
        }
    }
    System.Console.WriteLine($"Число {number} встречается {count} раз");
    
}
