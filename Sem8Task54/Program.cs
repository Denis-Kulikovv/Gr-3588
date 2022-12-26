// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.


int row = ReadData("Введите количество строк : ");              // Пользователь вводит количество строк
int column = ReadData("Введите количество столбцов : ");       // Пользователь вводит количество столбцов
int[,] array2D = Fill2DArray(row, column, 1, 100);            // Генерируем массив
Print2DArrayColor(array2D);                                  // Выводим в консоль разным цветом элементы 
Console.WriteLine();
SortingRow(array2D);                                       // Сортируем построчно элементы по убыванию
Print2DArrayColor(array2D);                               // Выводим отсортированный массив разным цветом элементы


int ReadData(string line)                                 // Чтение данных из консоли 
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
                                                                                // заполненный случайными числами
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


void Insert(bool isRow, int dim, int[] source, int[,] dest) //  Метод с помощью которого мы меняем значения в стоке 
                                                           // или столбце исходного массива на отсортированные значения
{
    for (int k = 0; k < source.Length; k++)
    {
        if (isRow)
            dest[dim, k] = source[k];
        else
            dest[k, dim] = source[k];
    }
}

void BubbleSort(int[] inArray)                         // Метод сортировки пузырьком 1 мерного массива          
{
    for (int i = 0; i < inArray.Length; i++)
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] < inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
}

void SortingRow(int[,] array2D)                   // Метод сортировки 2 мерного массива построчно
{
    int[] rowArr = new int[column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            rowArr[j] = array2D[i, j];
        BubbleSort(rowArr);
        Insert(true, i, rowArr, array2D);
    }
}




// int[,] SortingRow (int[,] array2D) // Метод сортировки всего 2 мерного массива (Возвр весь массив по порядку)
// {
//                 int minVal = array2D[0,0];
//                 for (int i = 0; i < array2D.GetLength(0); i++)// перечисление строк
//                 {
//                     for (int j = 0; j < array2D.GetLength(1); j++)// перечисление символов(столбцов)
//                     {
//                         for (int q = i; q < array2D.GetLength(0); q++)//перечесления строк для проверки
//                         {
//                             for ( int w =(q==i)?j:0; w < array2D.GetLength(1); w++)   // перечесление смиволов для проверки (исключаем проверенные и заменннеые символы)
//                             {

//                                 if (array2D[i, j] < array2D[q, w])
//                                 {
//                                     minVal = array2D[q, w];
//                                     array2D[q, w] = array2D[i, j];
//                                     array2D[i, j] = minVal;
//                                 }

//                             }
//                         }

//                     }
//                 }

//                 return array2D;
// }


