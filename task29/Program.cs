// Напишите программу, которая задаёт массив из 8 элементов, заполненный псевдослучайными числами и выводит их на экран.

Console.WriteLine("Введите длинну массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int num)
{
    int[] array = new int[num];
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 100);
        index++;
    }
    return array;
}

void PrintArray(int[] col)
{
    Console.Write("[");
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;

        if (position < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int[] arr = FillArray(num);
PrintArray(arr);


