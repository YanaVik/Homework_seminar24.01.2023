// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double a;
double b;
double c;

Console.WriteLine("Введите число, которое вы хотите возвести в степень:");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите степень, в которую хотите возвести число "+a+":");
b = Convert.ToDouble(Console.ReadLine());

c = Math.Pow(a, b);

Console.WriteLine("Готово! "+a+" в степени "+b+" равно "+c+"!");
Console.ReadLine();