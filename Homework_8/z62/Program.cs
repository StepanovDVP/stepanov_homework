Console.Clear();
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

int[,] GetMatrix(int[,] mat)
{
       int i = 0; int j = 0; int di = 0; int dj = 1;
       for (int k = 0; k < 16; k++)
       {
            mat[i,j] = k + 1;
            int x = (i + di) % 4;
            int y = (j + dj) % 4;
            if (y == -1) y = 3; // \ 00 / 
            if (mat[x, y] != 0)
            {
                int temp = di;
                di = dj;
                dj = -temp;
            }
            i = i + di;
            j = j + dj;
       }
       return mat;
}
void PrintMatrix (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {   
            if(arr[i, j]< 10){Console.Write($"0{arr[i, j]} ");}
            else{Console.Write($"{arr[i, j]} ");}
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[4,4];


GetMatrix(matrix);
PrintMatrix(matrix);