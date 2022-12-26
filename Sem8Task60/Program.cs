// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

List<int> num = new List<int>(90); // Заполняем список 2 значными числами
for (int i = 0; i < 90; i++)
{
    num.Add(10 + i);
}

int row = ReadData("Введите количество строк : ");      
int column = ReadData("Введите количество столбцов : ");
int list = ReadData("Введите количество листов : ");
int[,,] arr3D = Fill3DArray(row, column, list);  // Заполняем массив неповторяющимися 2 значными целыми числами 
Print3DArray(arr3D);                            // Выводим в консоль массив

int ReadData(string line) // Метод считывает данные и возвращает число
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,,] Fill3DArray(int countRow, int countColumn, int countList) // Метод генерации и заполнения 
                                                                 // трехмерного массива 
{
    
    int[,,] array3D = new int[countRow, countColumn, countList];

    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[i, j, z] = GenNum(num);
            }
        }

    }
    return array3D;
}

void Print3DArray(int[,,] matrix)                  // Метод выводит 3 мерный массив в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                Console.Write(matrix[i, j, z] + "(" + i + "," + j + "," + z + ")" + " ");
            }
            Console.WriteLine();
        }
    }

}

int GenNum(List<int> num)                         // Метод принимает список 2 значных чисел и возвращает 
                                                 // случайное число, удаляя его из списка
{
    int index = new Random().Next(0, num.Count);
    int outNum = num[index];
    num.RemoveAt(index);
    return outNum;
}

