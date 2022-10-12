//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Zadacha1()
{
    Random random = new Random();
    int rows = random.Next(3, 6);
    int columns = random.Next(3, 6);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    SortArray(numbers, rows, columns);
    Console.WriteLine(" ");
    PrintArray(numbers);
}
void FillArray(int[,] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = random.Next(-9, 10);
        }
    }
}
void PrintArray(int[,] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void SortArray(int[,] numbers, int rows, int columns)
{
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                for (int k = 0; k < numbers.GetLength(1) - 1; k++)
                {
                    if (numbers[i, k] < numbers[i, k + 1])
                    {
                        int temp = numbers[i, k + 1];
                        numbers[i, k + 1] = numbers[i, k];
                        numbers[i, k] = temp;
                    }
                }
            }
        }
    }
}
//Zadacha1();
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void Zadacha2()
{
    Random random = new Random();
    int rows = random.Next(4, 5);
    int columns = random.Next(4, 5);
    int[,] numbers = new int[rows, columns];
    FillArray2(numbers);
    PrintArray2(numbers);
    FindMin(numbers, rows, columns);
}
void FillArray2(int[,] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = random.Next(0, 10);
        }
    }
}
void PrintArray2(int[,] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void FindMin(int[,] numbers, int rows, int columns)
{
    int[] numbers2 = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        numbers2[i] = 0;
        for (int j = 0; j < columns; j++)
        {
            numbers2[i] = numbers2[i] + numbers[i, j];
        }
    }
    for (int j = 0; j < numbers2.Length; j++)
    {
        Console.Write(numbers2[j]);
        Console.WriteLine(" ");
    }
    Console.Write($"Строка с наименьшей суммой элементов {Array.IndexOf(numbers2, numbers2.Min()) + 1}");
}
//Zadacha2();
//Напишите программу, которая заполнит спирально массив 4 на 4.
void Zadacha3()
{
    {
        int  n= 4;
        int  m= 4;
    int[,] Arr = new int[n, m];
        int i = 0, j, k = 0, p = 1;

        while (i < n * m) 
        {
            k++;
            for (j = k - 1; j < m - k + 1; j++)
            {
                Arr[k - 1, j] = p++;
                i++;
            }  

            for (j = k; j < n - k + 1; j++)
            {
                Arr[j, m - k] = p++;
                i++;
            }  

            for (j = m - k - 1; j >= k - 1; j--)
            {
                Arr[n - k, j] = p++;
                i++;
            }  

            for (j = n - k - 1; j >= k; j--)
            {
                Arr[j, k - 1] = p++;
                i++;
            } 

        }

   for (int t = 0; t < n; t++)
    {
        for (int l = 0; l < m; l++)
        {
            Console.Write(Arr[t, l] + "\t");
        }
        Console.WriteLine();
    }
    }
}
Zadacha3();