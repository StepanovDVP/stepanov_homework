Console.Clear();
Console.WriteLine("*** Задача 19 ***"); //Напишите программу, 
// которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
string enter_number(string text){
     Console.Write(text);
     int n = int.Parse(Console.ReadLine());
     string strN = n.ToString();
     return strN;
}    
string palindrome(string n){ 
     int len = n.Length;
     int index = 0;
     string result = "да";
     while (index < len/2){
          if (n[index] == n[len  - 1 - index])result = "да";
          else result = "нет";
          index = index + 1;
     }
     return result;
}
string test = enter_number("enter number: ");
Console.WriteLine(palindrome(test));

Console.WriteLine("*** Задача 21 ***"); // Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
void enterDots(int[] collection){
     int index  = 0;
     int len = collection.Length;
     string[] array ={"x1 ", "y1 ", "z1 ", "x2 ", "y2 ", "z2 "};
     while (index < len){
          Console.Write($"enter {array[index]}");
          collection[index] = int.Parse(Console.ReadLine());
          index++;
     }
}
double distance(int [] array){
     double d = Math.Sqrt(Math.Pow((array[3] - array[0]), 2) + 
     Math.Pow((array[4] - array[1]), 2) + 
     Math.Pow((array[5] - array[2]), 2));
     return Math.Round(d, 2);
}

int[] array_coordinastes = new int[6];
enterDots(array_coordinastes);
double result_found = distance(array_coordinastes);
Console.WriteLine(result_found);

Console.WriteLine("*** Задача 23 ***"); // Напишите программу, которая принимает на вход число 
//(N) и выдаёт таблицу кубов чисел от 1 до N.
void cube(string text){
     Console.WriteLine(text);
     int n = int.Parse(Console.ReadLine());
     int count = 1;
     while (n >= count){
          Console.Write($"{Math.Pow(count, 3)}, ");
          count++;
     }
}
cube("enter number: ");
