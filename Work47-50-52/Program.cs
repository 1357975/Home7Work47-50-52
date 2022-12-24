void Zadacha47()
//Задача 47: Задайте двумерный массив размером m×n, заполненный 
//случайными вещественными числами, округлёнными до одного знака.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

{
    Console.WriteLine("Задача 47.");

    int rows = 3;
    int columns =4;

    Double[,]numbers=new Double[rows,columns];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);

}

void FillArray(Double[,] matr, Double minValue, Double maxValue)
{
    maxValue++;
    Random rand = new Random();


    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++) 
            {
                matr[i,j]=Math.Round(rand.NextDouble()*(maxValue-minValue)+minValue, 1);
            }
    } 
}

void PrintArray(Double[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++) 
            {
            Console.Write($" {matr[i,j]} ");
            }
    Console.WriteLine();       
    } 
}

void Zadacha50()
//Задача 50. Напишите программу, которая на вход принимает 
//индексы элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 3 -> 3

{
    Console.WriteLine("Задача 50.");

    Console.WriteLine("Введите ширину массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите длину массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    
    int[,] numbers = new int[rows, columns];

    FillArray2(numbers,0,9);
    PrintArray2(numbers);

    Console.WriteLine("Введите значение X: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение Y: ");
    int y = Convert.ToInt32(Console.ReadLine());

    void FindElement(int[,] matr)
    {
        if (x < rows && y < columns)
        {
            Console.WriteLine("Выбранный элемент: " + numbers[x, y]);
        }
        else
        {
            Console.WriteLine("Такого числа нет");
        }
    }
    FindElement(numbers);
}

void FillArray2(int[,] matr, int minValue, int maxValue)
{
    maxValue++;
    Random rand = new Random();


    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++) 
            {
                matr[i,j]=rand.Next(minValue,maxValue);
            }
    Console.WriteLine();       
    } 
}

void PrintArray2(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++) 
            {
            Console.Write($" {matr[i,j]} ");
            }
    Console.WriteLine();       
    } 
}

void Zadacha52()
//Задача 52. Задайте двумерный массив из целых чисел. Найдите 
//среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 5 3
//8 4 6 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.
{
    Console.WriteLine("Задача 52.");

    int rows = 3;
    int columns =4;

    int[,]numbers=new int[rows,columns];
    FillArray2(numbers,0,9);
    PrintArray2(numbers);

    for (int j = 0; j < columns; j++)
    {
            double srAr = 0;
            for (int i = 0; i < rows; i++)
            {
                srAr += numbers[i,j];
            }
    Console.WriteLine("Среднее арифметическое столбца "+ (j) + " равно: " + Math.Round((srAr/rows),1));
    }

}


Zadacha47();
Zadacha50();
Zadacha52();

