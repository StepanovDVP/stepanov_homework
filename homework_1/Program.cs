Console.Clear();
Console.WriteLine("************* ЗАДАЧА_2 **************");
Console.Write("Enter a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter b: ");
int b = int.Parse(Console.ReadLine());
if (a > b) {Console.WriteLine($"a = {a}, b = {b} -> max = {a}");}
else {Console.WriteLine($"a = {a}, b = {b} -> max = {b}");}

Console.WriteLine("************* ЗАДАЧА_4 **************");
Console.WriteLine("Enter number_1, number_2, number_3: ");
int number_1 = int.Parse(Console.ReadLine());
int number_2 = int.Parse(Console.ReadLine());
int number_3 = int.Parse(Console.ReadLine());
int max_number = number_1; 
int count = 0;
while (count < 2){
    if (max_number < number_2) {max_number = number_2;}
    if (max_number < number_3) {max_number = number_3;}
    count += 1;
}
Console.WriteLine($"{number_1}, {number_2}, {number_3} -> max = {max_number}");

Console.WriteLine("************* ЗАДАЧА_6 **************");
Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0){Console.WriteLine($"{number} - > да");}
else {Console.WriteLine($"{number} - > нет");}

Console.WriteLine("************* ЗАДАЧА_8 **************");
Console.WriteLine("Enter number N: ");
int N = int.Parse(Console.ReadLine());
int count_n = 1;
var someList = new List<int>();
while (N >= count_n)
{
    count_n += 1;
    if (count_n % 2 == 0){someList.Add(count_n);}
}
Console.Write($"{N} -> ");
foreach (var item in someList)
{
    Console.Write($"{item}, ");
}
