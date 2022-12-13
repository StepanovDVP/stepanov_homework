Console.Clear();
Console.WriteLine("*** Задача 25 ***");//Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B (без использования Math.Pow).
int EnterNum(string text){
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int sqrt(int a, int b){
    int result = 1;
    for (int i = 0; i < b ; i++){result = result * a;}
    return result;
}
Console.WriteLine(sqrt(EnterNum("enter A: "), EnterNum("enter B: ")));

Console.WriteLine("*** Задача 27 ***");//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SummOfNumber(int i){
    char[] arr = i.ToString().ToCharArray();
    int sum = 0;
    for (int j = 0; j < arr.Length; j++) {sum = sum + int.Parse(arr[j].ToString());}
    return sum;
}
Console.WriteLine(SummOfNumber(EnterNum("введите число: ")));

Console.WriteLine("*** Задача 29 ***");//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] EnterArray(int[] array){
    for (int i = 0; i < array.Length; i++) {array[i] = new Random().Next(0, 999);}
    return array;
}
int[] list = new int[EnterNum("введите длину массива: ")];
Console.WriteLine($"[{string.Join(", ", EnterArray(list))}]");
