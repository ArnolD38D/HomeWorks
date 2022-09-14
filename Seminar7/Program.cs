
/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.

void CreateRandom2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(0, 10))/10;
        }
    }
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = new double [m, n];
CreateRandom2dArray(myArray);
Show2dArray(myArray);
*/

/*
// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

void CreateRandom2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array [i,j] = new Random().Next(0, 10); 
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("введите номер строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] myArray = new int [3,4];

CreateRandom2dArray(myArray);
Show2dArray(myArray);

if (m > myArray.GetLength(0) || n > myArray.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
    Console.WriteLine($"Значение элемента - {myArray[m-1,n-1]}");
*/

/*
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

void CreateRandom2dArrey (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] myArray = new int[n, m];
CreateRandom2dArrey (myArray);
Show2dArray(myArray);

for (int j = 0; j < myArray.GetLength(1); j++)
{
    double meanArithmetic = 0;
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        meanArithmetic += myArray[i, j];
    }
    meanArithmetic = Math.Round(meanArithmetic / n, 1);
    
    Console.WriteLine($"Средне арифметическое столбца № {j+1} = {meanArithmetic}");
}
*/
