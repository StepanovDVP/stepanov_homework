Console.Clear();
Console.WriteLine("**** Задача 34 ****");// Задайте массив заполненный 
// случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

int[] ThreeDigitArr(int size, int firstVal, int lastVal){
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(firstVal, lastVal);
    }
    return arr;
}
int EvenNumbers(int[] arr){
    int count = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] % 2 == 0) count++;
    }
    return count;
}

int[] arrayOne = ThreeDigitArr(5, 100, 1000);
Console.WriteLine($"[{string.Join(", ", arrayOne)}] -> кол-во четных: {EvenNumbers(arrayOne)}");
Console.WriteLine();
Console.WriteLine("**** Задача 36 ****"); //Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int SummOfUneven(int[] arr){
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) sum = sum + arr[i];
    }
    return sum;
}
int[] arrayTwo = ThreeDigitArr(4, -10, 10);
Console.WriteLine($"[{string.Join(", ", arrayTwo)}] -> сумма нечетных позиций: {SummOfUneven(arrayTwo)}");
Console.WriteLine();
Console.WriteLine("**** Задача 38 ****"); //Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.

int Difference(int[] arr){
    int max = arr[0];
    int min = arr[0];
    for (int i = 0; i < arr.Length - 1 ; i++)
    {
        if (max < arr[i + 1]) max = arr[i + 1];
        if (min > arr[i + 1]) min = arr[i + 1];
    }
    return max - min;
}

int[] arrayThree = ThreeDigitArr(5, 0, 100); 
Console.WriteLine($"[{string.Join(" ", arrayThree)}] ->");
Console.WriteLine($"-> Разницa между max и min элементов массива: {Difference(arrayThree)}");
