// task 1  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];

    int[,] arrayInt = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
        {
            array[i, j] += new Random().NextDouble();
            array[i, j] = Math.Round(array[i, j], 1);
        }
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine(); 
    }
    Console.WriteLine();
}

Console.Write("Введите колличество строк = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов = ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива = ");
int miValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива = ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(rows, columns, miValue, maxValue);
Show2dArray(myArray);


// task 2 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
/*

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void NahoshdenieElemnt(int row,int column, int[,] array)
{
    if(row <= array.GetLength(0) && column <= array.GetLength(1))
        Console.WriteLine($"Элемент под индексом {row},{column} = {array[row,column]}");
    else Console.WriteLine("С таким индексом нет элемента в массиве");
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine(); 
    }
    Console.WriteLine();
}

Console.Write("Введите колличество строк = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов = ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива = ");
int miValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива = ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, miValue, maxValue);
Show2dArray(myArray);

Console.Write("Введите индекс строки = ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца = ");
int column = Convert.ToInt32(Console.ReadLine());
NahoshdenieElemnt(row, column, myArray);
*/


// task 3 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine(); 
    }
    Console.WriteLine();
}

double[] SredArifColoms(int[,] array)
{
    double[] sred = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            sred[j] += array[i,j];
        sred[j] = sred[j] / array.GetLength(0);
        sred[j] = Math.Round(sred[j], 1);
    }
    return sred;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Введите колличество строк = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов = ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива = ");
int miValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива = ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, miValue, maxValue);
Show2dArray(myArray);

double[] sred = SredArifColoms(myArray);
Console.Write("Среднее арифметическое значение в столбцах -> ");
ShowArray(sred);
*/