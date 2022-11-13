int mas = ReadInt("Введите индекс строки: ");
int colums = ReadInt("Введите индекс столбца: ");
int[,] numbers = new int[6, 8];
FillArray2D(numbers);
PrintArray2D(numbers);

if (mas < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[mas, colums]);
else Console.WriteLine($"{mas}{colums} -> такого числа в массиве нет");


// Заполнение массива случайными числами от 1 до 9

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Вывод массива в терминал
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Ввод 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}