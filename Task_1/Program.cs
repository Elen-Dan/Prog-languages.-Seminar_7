/*
Задача 1. 
Задайте двумерный массив размером m×n, заполненный случайными вещественными (тип double) числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

*/
Console.Clear();
Console.WriteLine("Введите число строк массива: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
double[,] Array = new double[Num1, Num2];
Console.WriteLine();

for (int i = 0; i < Num1; i++)
{
    for (int j =0; j < Num2; j++)
    {
        Array[i, j] = new Random().NextDouble()*100;
        Console.Write("{0,6:F2}", Array[i, j]);
    }
Console.WriteLine();    
}


