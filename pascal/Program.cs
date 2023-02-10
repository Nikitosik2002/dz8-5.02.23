int linCol = 7;
int[,] triangle = new int[linCol,linCol];
const int numberWeight = 4;
void fillTriangle()
{
    for (int i = 0; i < linCol; i++)
    {
        triangle[i,0] = 1;
        triangle[i,i] = 1;

    }

    for (int i = 2; i < linCol; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i,j] = triangle[i-1, j-1] + triangle[i-1, j];
        }
    }
}

void printTriangle()
{
    for (int i = 0; i < linCol; i++)
    {
        for (int j = 0; j < linCol; j++)
        {
            if(triangle[i,j] != 0)
            System.Console.Write($"{triangle[i,j], numberWeight}");
        }
        System.Console.WriteLine();
    }
}

Console.ReadLine();
fillTriangle();
//printTriangle();
Console.ReadLine();

void isosceles()
{   
    int col = numberWeight * linCol;
    for (int i = 0; i < linCol; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition (col, i + 1);
            if (triangle[i,j] != 0) System.Console.Write($"{triangle[i,j],numberWeight}");

            col += numberWeight * 2;
        }

        col = numberWeight * linCol - numberWeight * (i + 1);
        System.Console.WriteLine();
    }
}

System.Console.WriteLine();
isosceles();
