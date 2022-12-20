// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double k1 = ReadData("Введите число k1 : ");  // Просим пользователя ввести значения
double b1 = ReadData("Введите число b1 : ");
double k2 = ReadData("Введите число k2 : ");
double b2 = ReadData("Введите число b2 : ");

double x = (b2 - b1) / (k1 - k2);  // Координаты x и y, при условии пересечения прямых. 
double y = k1 * x + b1;

if (PointOfIntersection(k1, b1, k2, b2))
    PrintData("Эти прямые пересекаются, координаты точки пересечения : " + "(" + x + "," + y + ")");
else PrintData("Эти прямые не пересекаются ");

int ReadData(string msg)     // Метод считывает данные, введенные пользователем и возвращает число
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)   // Метод выводит результат в консоль 
{
    Console.WriteLine(res);
}

bool PointOfIntersection(double k1, double b1, double k2, double b2) // Метод проверяет пересекаются ли прямые
{
    return (k1 * x + b1 == k2 * x + b2);
}
