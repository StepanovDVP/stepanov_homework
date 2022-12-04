Console.Clear();
Console.WriteLine("*** Задача 10 ****"); //Напишите программу, которая 
// принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
int number =  new Random().Next(100, 1000);
Console.WriteLine(number);
int result = number / 10 % 10;
Console.WriteLine(result);
Console.WriteLine("*** Задача 13 ****");// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
Console.Write($"Enter number: ");
int number1 = int.Parse (Console.ReadLine());
if (number1 / 100 == 0) Console.WriteLine("третьей цифры нет");
else {
     string numberStr =  number1.ToString();
     Console.WriteLine(numberStr[2]);
}
Console.WriteLine("*** Задача 15 ****");// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write($"Enter number day: ");
int day = int.Parse(Console.ReadLine());
if (day > 5) Console.WriteLine($"{day} - Выходной день !");
else Console.WriteLine($"{day} - не выходной день!");