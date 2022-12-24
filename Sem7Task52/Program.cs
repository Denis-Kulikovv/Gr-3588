// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int ReadData(string line) // Метод считывает данные и возвращает число
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder) // Метод генерации и заполнения 
                                                                                 // двумерного массива 
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Print1DArr(int[] arr)// Метод принимает массив и выводит его в консоль, каждый элемент через запятую
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}
int[] AvgColumn(int[,] arr2D) // Метод принимает 2 мерный массив и выводит одномерный со средним арифметическим
                              // столбцов   
{
    int[] avg = new int[arr2D.GetLength(1)];
    for (int j=0; j < arr2D.GetLength(1); j++)
    {
        for (int i=0; i < arr2D.GetLength(0);i++)
        {
            avg[j]+=arr2D[i,j];
        }
        avg[j]= avg[j]/arr2D.GetLength(0);
    }
    return avg;
}

int row = ReadData("Введите количество строк : ");
int column = ReadData("Введите количество столбцов : ");
int[,] arr2D = Fill2DArray(row, column, 5, 99);  // Заполняем массив положительными целыми числами диапазона
Print2DArray(arr2D);                            // Выводим в консоль массив
int[] res = AvgColumn(arr2D);                  // Массив среднее арифметическое элементов в каждом столбце 2 мерного
Print1DArr(res);                              // Выводим в консоль массив 1 мерный    
