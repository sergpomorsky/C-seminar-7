// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Задайте двумерный массив");
Console.Write("Введите столбец n ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите строку m ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next (1, 10);
        Console.Write(matrix[i,j] + " "); 
    }
    Console.WriteLine();
}

//Console.WriteLine(matrix.GetLength(0));
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = sum + matrix[i, j];
    }
    Console.WriteLine($"Ср.арифметическое равно { sum / matrix.GetLength(0)} ");
}
Console.ReadLine();

