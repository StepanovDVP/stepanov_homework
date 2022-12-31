Console.Clear();
// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//метод для получения размера массива
int GetInt(string text)
{
    Console.Write(text);
    int n = int.Parse(Console.ReadLine());
    return n;
}
// метод для получения рандомного неповторяющегося числа
int GetUniqueNumber(int n)
{
    int num = new Random().Next(10, 100);
    if (n == num) GetUniqueNumber(num);
    return num;
}
// метод для создания одномерного  массива из уникальных чисел
List<int> UniqueList(int x, int y, int z)
{
    var someList = new List<int>();
    for (int i = 0; i < (x * y * z); i++)
    {
        someList.Add(new Random().Next(10, 100));
        while (true)
        {
            bool res = true;
            for (int j = 0; j < someList.Count; j++)
            {
                if (i == j) continue;
                if (someList[i] == someList[j])
                {
                    someList[i] = GetUniqueNumber(someList[i]);
                    res = false;
                }
            }
            if (res) break;
        }
    }
    return someList;
}
// задаем размер массива
int x = GetInt("x: ");
int y = GetInt("y: ");
int z = GetInt("z: ");
// получаем одномерный массив
List<int> temp = UniqueList(x, y, z);
// метод для заполнения трёхмерного массива из неповторяющихся двузначных чисел
int[,,] CreateArr3d(int[,,] arr)
{
    int index = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {   
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = temp[index];
                index++;
            }
        }
    }
    return arr;
}
// создаем трехмерный массив
int[,,] arr3d = new int[x, y, z];
CreateArr3d(arr3d);
// вывод в консоль трехмерного массива
void PrintArr(int[,,] arr){
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                Console.Write($"{arr[x, y, z]} ({x}{y}{z}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
PrintArr(arr3d);
