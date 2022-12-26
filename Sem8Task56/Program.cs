// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

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

void Print2DArray(int[,] matrix)                  // Метод выводит 2 мерный массив в консоль
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

void PrintData(string res)   // Метод выводит результат в консоль 
{
    Console.WriteLine(res);
}

int MinRow(int[,] arr2D) // Метод принимает 2 мерный массив и выводит индекс строки с наименьшей суммой элементов   
{
    int minIndex = -1;
    int minRow = int.MaxValue;
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            sum += arr2D[i, j];
        }
        if (minRow > sum)
        {
            minRow = sum;
            minIndex = i;
        }

    }
    return minIndex;
}

int row = ReadData("Введите количество строк : ");
int column = ReadData("Введите количество столбцов : ");
int[,] arr2D = Fill2DArray(row, column, 5, 99);  // Заполняем массив положительными целыми числами диапазона
Print2DArray(arr2D);                            // Выводим в консоль массив
int res = MinRow(arr2D);                  // Находим инднкс строки с нименьшей суммой элементов
PrintData("Номер строки с наименьшей суммой элементов: " + (res+1));    // Выводим в консоль результат    