// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int rowA = ReadData("Введите количество строк первой матрицы : "); // Пользователь вводит количество строк
int columnB = ReadData("Введите количество столбцов первой матрицы : ");// Пользователь вводит количество столбцов
int[,] a = Fill2DArray(rowA, columnB, 1, 10);            // Генерируем массив (матрица а)
Print2DArrayColor(a);                                  // Выводим в консоль разным цветом элементы 
Console.WriteLine();
int rowC = ReadData("Введите количество строк второй матрицы : ");// Пользователь вводит количество строк
int columnD = ReadData("Введите количество столбцов второй матрицы : ");  // Пользователь вводит количество столбцов
int[,] b = Fill2DArray(rowC, columnD, 1, 10);            // Генерируем массив (матрица b)
Print2DArrayColor(b);                                  // Выводим в консоль разным цветом элементы 
Console.WriteLine();
int[,] c = Multiplication(a, b);               // Перемножаем 2 массива
Print2DArrayColor(c);                         // Выводим в консоль разным цветом элементы



int ReadData(string line)                    // Метод считывает данные из консоли и возвращает число
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void Print2DArrayColor(int[,] matrix)                   // Метод вывода 2 мерного массива разными цветами в консоль
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[matrix[i, j] % 15];
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder) // Генерируем двумерный массив, 
                                                                                 // заполненный случайными числами диап.
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

int[,] Multiplication(int[,] a, int[,] b) // Метод перемножения 2х матриц (принимает 2 2х мерных массива, возвращает 1)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}