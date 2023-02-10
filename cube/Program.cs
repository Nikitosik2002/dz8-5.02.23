System.Console.WriteLine("Введите длинну, ширину и высоту куба");
int n = Convert.ToInt32(Console.ReadLine());
int[,,] cube = new int[n,n,n];
int count = 10;
for (int i = 0; i < cube.GetLength(0); i++)
{
    for (int j = 0; j < cube.GetLength(1); j++)
    {
        for (int k = 0; k < cube.GetLength(2); k++)
        {
                cube[i,j,k] = count;
                count++;
        }
    }
}



for (int i = 0; i < cube.GetLength(0); i++)
{
    for (int j = 0; j < cube.GetLength(1); j++)
    {
        for (int k = 0; k < cube.GetLength(2); k++)
        {
          System.Console.WriteLine($"цифра {cube[i,j,k]} стоит на позиции {i}, {j}, {k}");  
        }
        System.Console.WriteLine();
    }
}