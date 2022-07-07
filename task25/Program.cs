﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int numDeg(int numA, int numB)
{
    int i = 1;
    int result = 1;
    while (i <= numB)
    {
        result = result * numA;
        i++;
    }
    return result;
}
int numberDeg = numDeg(numA, numB);
Console.WriteLine($"Число {numA} в степени {numB} = " + numberDeg);