Console.Clear();
// Задача 54: Задайте двумерный массив. Напишите программу, которая
//  упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:


int GetSize(string text)
{
    Console.Write(text);
    int size = int.Parse(Console.ReadLine());
    return size;
}

int[,] GetArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}

int[,] SortedArr(int[,] arr)
{
    int count = 0;
    while (count < arr.GetLength(0))
    {
        int[] tempArr = new int[arr.GetLength(1)];
        for (int i = 0; i < arr.GetLength(1); i++) tempArr[i] = arr[count, i];
        Array.Sort(tempArr);
        Array.Reverse(tempArr);
        for (int i = 0; i < tempArr.Length; ++i) arr[count, i] = tempArr[i];
        count++;
    }
    return arr;
}

void PrintArr(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Задайте размер массива");
int[,] mas = new int[GetSize("row: "), GetSize("column: ")];
GetArray(mas);
PrintArr(mas);
SortedArr(mas);
Console.WriteLine();
PrintArr(mas);
