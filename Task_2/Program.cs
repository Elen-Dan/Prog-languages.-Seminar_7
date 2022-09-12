/*
Задача 2. 
Напишите программу, которая на вход принимает позиции (две) элемента в двумерном массиве, и возвращает значение этого 
элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
Console.Clear();
Console.WriteLine("Введите первую позицию: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую позицию: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
//Создаем массив со случайными числами от 1 до 10:
int[,] Array = new int[10, 10];
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Array[i, j] = new Random().Next(1, 10);
        Console.Write($"{Array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
if (Num1>=0 & Num1 <=10 & Num2>=0 & Num2 <=10) 
    
        Console.WriteLine("На введенной позиции находится число: " + Array[Num1,Num2]);
else    
        Console.WriteLine("Такой позиции не существует");