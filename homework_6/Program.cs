Console.Clear();
Console.WriteLine("**** Задача 41 ****"); //Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
List<int> CreateArr(){
    var someList = new List<int>();
    bool x = true;
    Console.WriteLine("!!!! Для завершения нажмите q !!!!");
    while (x == true){
        Console.Write($"Введите число: "); 
        string y = Console.ReadLine();
        if (y == "q") x = false;
        else someList.Add(int.Parse(y));
    }
    return someList;
}

var someList = CreateArr();
int count = 0;
foreach (var item in someList) {if (item > 0) count++;}
Console.WriteLine($"[{string.Join(", ", someList)}] -> кол-во положительных {count}");
Console.WriteLine();
Console.WriteLine("**** Задача 43 ****"); //Напишите программу, которая найдёт 
//точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double InputData(string text){
    Console.Write(text);
    double n  = double.Parse(Console.ReadLine());
    return n;
}
void LineIntersection(double b1, double k1, double b2, double k2){
    double x = -(b1 - b2) / (k1 - k2);
    double y = (k2 * x) + b2;
    Console.WriteLine($"точка пересечения прямых ({Math.Round(x, 2)}, {Math.Round(y, 2)})");
}

LineIntersection(InputData("b1 = "), InputData("k1 = "), InputData("b2 = "), InputData("k2 = "));