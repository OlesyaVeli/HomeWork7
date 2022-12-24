

/* Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/
/*
double[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    double[,] array = new double[rows, colums];
    Random rand = new Random();
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue) + rand.NextDouble();
        }
    }
    return array;
}


void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
             Console.Write(array[i, j] + "\t");        
        }  
        Console.WriteLine();       
    }
    Console.WriteLine();
    
}

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
double[,] myArray = CreateRandom2dArray(rows, colums, minValue, maxValue);
Show2dArray(myArray);
*/

/* Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
   и возвращает значение этого элемента или же указание, что такого элемента нет.*/

int[,] CreateArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}



void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0;j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateArray(rows, colums, minValue, maxValue);
Show2dArray(myArray);

Console.WriteLine("Введите номер строки: ");
int numRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int numColums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
    


void FindElement2dArray(int[,] array)
{  
    if(numRows-1 < array.GetLength(0) && numColums-1 < array.GetLength(1))
        Console.Write($"Элемент, находящийся в строке {numRows} столбце {numColums} = {array[numRows-1,numColums-1]}");
    else
        Console.Write("Такого элемента не существует");       
}

FindElement2dArray(myArray);




/* Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*/
/*
int[,] CreateArray(int rows, int colums, int minValue, int maxValue)
 {
     int[,] array = new int[rows, colums];

     for(int i = 0; i < rows; i++)
     {
         for(int j = 0; j < colums; j++)
         {
             array[i,j] = new Random().Next(minValue, maxValue);
         }
     }
     return array;
 }

 void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0;j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    
}

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateArray(rows, colums, minValue, maxValue);
Show2dArray(myArray);


double[] Average(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i,j];
        average[j] = sum / array.GetLength(0);
    }
    return average;
}


void ShowArray(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        Console.Write(array[i] + "\t");
    Console.WriteLine();
}

double[] average = Average(myArray);
ShowArray(average);
*/

