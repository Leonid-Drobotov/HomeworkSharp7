// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("введите номер строки");
int numberLine = int.Parse(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int numberColumn = int.Parse(Console.ReadLine());
int [,] numbers = new int [10,10];
CreateRandomArray(numbers);

if (numberLine > numbers.GetLength(0) || numberColumn > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {numberLine} строки и {numberColumn} столбца равно {numbers[numberLine-1,numberColumn-1]}");
}

OutputArray(numbers);

void CreateRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void OutputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("|");
        Console.WriteLine(""); 
    }
}