/*
Задача 3. 
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
//Создаем массив со случайными числами от 1 до 10:
int[,] Array = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Array[i, j] = new Random().Next(1, 10);
        Console.Write($"{Array[i, j]} "); //выводим на консоль для дальнейшей наглядности
    }
    Console.WriteLine();
}

double Sum = 0;
double Avrg = 0;
int k = 0;
for (int i = 0; i < 5; i++)
{
    while (k != 5)
        {
        Sum = Sum + Array[k, i];
        k++;
        }
        //Console.WriteLine("Сумма столбца: " + i + " = " + Sum);
        Avrg = Sum / Array.GetLength(1);
        Console.WriteLine("Среднее арифметическое столбца: " + Avrg);
    k = 0;
    Sum = 0;
}    