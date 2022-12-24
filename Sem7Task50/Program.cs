// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

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

void PrintData(string res)// Метод выводит результат в консоль
{
    Console.WriteLine(res);
}

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

void Print2DArrayColor(int[,] matrix) // Метод выводит элементы массива в косоль разным цветом 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(matrix[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int SearchElement(int[,] arr2D, int x, int y) // Метод находит значение элемента 2 мерного массива
{
    int element = -1;
    if (x < arr2D.GetLength(0) && y < arr2D.GetLength(1))
    {
        element = arr2D[x, y];
    }
    return element;
}

int row = ReadData("Введите количество строк : ");
int column = ReadData("Введите количество столбцов : ");
int x = ReadData("Введите первое значение позиции : ");
int y = ReadData("Введите второе значение позиции : ");
int[,] arr2D = Fill2DArray(row, column, 5, 99);   // Заполняем массив положительными целыми числами диапазона
Print2DArrayColor(arr2D);                        // Выводим в консоль массив
int res = SearchElement(arr2D, x, y);             // Находим значение элемента
if (res == -1) PrintData("Такого элемента нет");   // Задаем отрицательное значение на случай выхода за рамки массива
else PrintData("Значение элемента : " + res);   // Выводим результат