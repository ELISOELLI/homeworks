﻿//task2 seminar1 C#
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два числа, чтобы узнать какое из двух чисел больше");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a > b) {Console.WriteLine("Первое введенное число больше второго: " + a + " - max; " + b + " - min.");}
else {Console.WriteLine("Второе введенное число больше первого: " + b + " - max; " + a + " - min.");}


//task4 seminar1 C#
/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите три числа, чтобы узнать какое из трех чисел максимальное");
int a = int.Parse(Console.ReadLine()); 
int b = int.Parse(Console.ReadLine()); 
int c = int.Parse(Console.ReadLine());

if (a > b && a > c) {Console.WriteLine(a + " максимальное число");}
else if (b > a && b > c) {Console.WriteLine(b + " максимальное число");}
else {Console.WriteLine(c + " максимальное число");}


//task6 seminar1 C# //
//* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите число, чтобы узнать является ли число чётным:");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0) {Console.WriteLine("Число " + a + " четное.");}
else {Console.WriteLine("Число " + a + " нечетное.");}

// task8 seminar1 C#
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8 

Console.WriteLine("Введите число, чтобы узнать все чётные числа данного числа:");
int a = int.Parse(Console.ReadLine());

if (a < 0) {
    Console.WriteLine("Введенное отрицательное число, попробуйте еще раз и введите положительное число.");
}
else if (a == 0 || a == 1) {Console.WriteLine("У данного чисела нет четных чисел");}
{
    int count = 1;
    while (count <= a)
    {
        if (count % 2 == 0)
        {
            Console.WriteLine(count);
        }
        count++;
    }
}    
