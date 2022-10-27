/*------------------------------------------------------------------------------------------------------------------------------------------
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
------------------------------------------------------------------------------------------------------------------------------------------

Console.WriteLine("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine()!);

double[,] Array = new double[m, n];
Random rnd = new Random();


void PrintArray(double[,] X)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{X[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetArray(double[,] X)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            X[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);
        }
    }
}

GetArray(Array);
Console.WriteLine();
PrintArray(Array);

*/
/*------------------------------------------------------------------------------------------------------------------------------------------
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
------------------------------------------------------------------------------------------------------------------------------------------

int[,] array = GetArray(5, 5, 0, 10);
PrintArray(array);

Console.WriteLine("Введите позицию элемента");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if (a > 4 && b > 4){
    Console.WriteLine("Tакого элемента нет!");
}
else{
    object c = array.GetValue(a,b)!;
    Console.WriteLine($"Найденное число: {c}");
}

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i=0; i < m; i++){
        for(int j=0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for(int i=0; i < array.GetLength(0); i++){
        for(int j=0; j< array.GetLength(1); j++){
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}
*/
/*------------------------------------------------------------------------------------------------------------------------------------------
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
------------------------------------------------------------------------------------------------------------------------------------------

int[,] array = GetArray(3, 4, 0, 9);
PrintArray(array);
double[] array2 = Average(array);
Console.Write($"Среднее арифметическое столбца: ");
PrintArray2(array2);

double[] Average(int[,] array){
    double[] result = new double[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(1); i++){
        double sum = 0;
        for(int j = 0; j < array.GetLength(0); j++){
            sum += array[j,i];
        }
        double Average = sum / array.GetLength(0);
        result[i] = Math.Round(Average, 1);
    }
    return result;
}

void PrintArray(int[,] Array){
    for(int i = 0; i < Array.GetLength(0); i++){
        for(int j = 0; j < Array.GetLength(1); j++){
            Console.Write($"{Array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray2(double[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]}; ");
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int [,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
*/