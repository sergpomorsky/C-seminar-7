// Задача 50: Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
Console.WriteLine("Задайте двумерный массив");
Console.Write("Введите n ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите m ");
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
Console.WriteLine("Введите позиции элемента в двумерном массиве");
Console.Write("Введите номер по горизонтали ");
int H = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер по вертикали ");
int V = Convert.ToInt32(Console.ReadLine());
        if (H < 0 | H > n | V < 0 | V > m)
        {
        Console.WriteLine("Такого элемента нет");
        }
        else
        {
        Console.WriteLine($"Значение элемента массива = {matrix[H, V]}");
        }
