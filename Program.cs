// General Methods
void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write("{0,2}|", Array[i, j]);
        }
        Console.WriteLine();
    }
}
void FullArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(100);
        }
    }


}
int ReadLine(string massage)
{
    Console.WriteLine(massage);
    var Value = int.Parse(Console.ReadLine()!);
    return Value;
}

//Exercise HomeWork Seminar#8 CSharp
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// int[,] Array1 = new int[3, 4]
// {
//  {1,4,7,2},
//  {5,9,2,3},
//  {8,4,2,4}
// };
// Console.WriteLine("Исходный массив:");
// PrintArray(Array1);
// Ordering(Array1);
// Console.WriteLine("В итоге получается вот такой массив:");
// PrintArray(Array1);
// void Ordering(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             for (int count = 0; count < matr.GetLength(1) - j - 1; count++)
//             {
//                 if (matr[i, count] < matr[i, count + 1])
//                 {
//                     int temp = matr[i, count];
//                     matr[i, count] = matr[i, count + 1];
//                     matr[i, count + 1] = temp;
//                 }
//             }
//         }
//     }
// }

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// int[,] Array2 = new int[4, 4]
// {
//  {1,4,9,9},
//  {5,9,9,3},
//  {8,4,2,4},
//  {5,2,6,7}
// };
// PrintArray(Array2);
// Console.WriteLine();
// Console.WriteLine("Cтрока с наименьшей суммой элементов: ");
// MinSumElements(Array2);
// void MinSumElements(int[,] array)
// {
//     int sumRow = 0;
//     int minRow = 0;
//     int minSumRow = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {      
//         minRow += array[0, i];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
//         if (sumRow < minRow)
//         {
//             minRow  = sumRow;
//             minSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.Write($"{minSumRow + 1} строка");
// }

//Задание 58. Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.
// int[,] Array1 = {
// {2,4},
// {3,2}
// };
// int[,] Array2 = {
// {3,4},
// {3,3}
// };
// int[,] MultiArray(int[,] Array1, int[,] Array2)
// {
//     int[,] Result = new int[2, 2];
//     for (int i = 0; i < Array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array2.GetLength(1); j++)
//         {
//             Result[i, j] = 0;
//             for (int k = 0; k < Array1.GetLength(1); k++)
//             {
//                 Result[i, j] += Array1[i, k] * Array2[k, j];
//             }
//         }
//     }
//     return Result;
// }
// PrintArray(MultiArray(Array1,Array2));

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
// int[,,] array4 = new int[2, 2, 5];
// int[] nums = new int[90];
// FillArray1(nums);
// FullArray2(array4, nums);
// PrintArray2(array4);
// void FillArray1(int[] Array)
// {
//     for (int i = 0; i < Array.Length; i++)
//     {
//         Array[i] = 10 + i;
//     }
// }
// void FullArray2(int[,,] Array, int[] element)
// {
//     int count = 0; int number;
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             for (int k = 0; k < Array.GetLength(2); k++)
//             {
//                 number = new Random().Next(90);
//                 while (element[number] == 0)
//                 {
//                     number = count;
//                     count++;
//                 }
//                 Array[i, j, k] = element[number];
//                 element[number] = 0;
//                 count = 0;
//             }
//         }
//     }
// }
// void PrintArray2(int[,,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {

//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             for (int k = 0; k < Array.GetLength(2); k++)
//             {
//                 Console.Write($"{Array[i, j, k]}({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// int n = 4;
// int number = 1;
// Print2(SpiralArray(n, number));
// int[,] SpiralArray(int n, int number)
// {
//     int[,] array = new int[n, n];
//     int count = 0;
//     int row; int column;
//     while (number < n * n + 1)
//     {
//         for (column = count; column < n - count; column++) array[count, column] = number++;
//         for (row = count + 1; row < n - count; row++) array[row, n - count - 1] = number++;
//         for (column = n - count - 2; column > count; column--) array[n - count - 1, column] = number++;
//         for (row = n - count - 1; row > count; row--) array[row, count] = number++;
//         count++;
//     }
//     return array;
// }
// void Print2(int[,] array)
// {
//     for (int row = 0; row < array.GetLength(0); row++)
//     {
//         for (int column = 0; column < array.GetLength(1); column++)
//         {
//             Console.Write("{0,6:d2}", array[row, column]);
//         }
//         Console.WriteLine();
//     }
// }

// Задание с семинара
//Задача 59: Отсортировать нечетные столбцы массива по возрастанию. Вывести массив изначальный и массив с отсортированными нечетными столбцами
// int rows = ReadLine("Rows; ");
// int colums = ReadLine("Colums; ");
// int[,] Array1 = new int[rows, colums];
// FullArray(Array1);
// Console.WriteLine("Исходный массив:");
// PrintArray(Array1);
// Ordering(Array1);
// Console.WriteLine("В итоге получается вот такой массив:");
// PrintArray(Array1);
// void Ordering(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (j % 2 == 0)
//             {
//                 for (int count = 0; count < matr.GetLength(0) - i - 1; count++)
//                 {
//                     if (matr[count, j] > matr[count + 1, j])
//                     {
//                         int temp = matr[count, j];
//                         matr[count, j] = matr[count + 1, j];
//                         matr[count + 1, j] = temp;
//                     }
//                 }
//             }
//         }
//     }
// }