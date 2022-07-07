// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNum (int num)
{
    int a = Convert.ToString(num).Length;
    int x = 0;
    int result = 0;
    for (int i = 0; i < a; i++)
    {
        x = num - (num % 10);
        result = result + (num - x);
        num = num / 10;
    }
    return result;
}
 int sumNum = SumNum(num);
 Console.WriteLine($"Сумма цифр в числе {num} = " + sumNum);