int X1 = ReadData("Введите координату Х1: ");
int Y1 = ReadData("Введите координату Y1: ");
int Z1 = ReadData("Введите координату Z1: ");
int X2 = ReadData("Введите координату Х2: ");
int Y2 = ReadData("Введите координату Y2: ");
int Z2 = ReadData("Введите координату Z2: ");
//Метод выводит данные пользователю
PrintData("Расстояние между точками: ", DistanceBetweenPoints3D(X1, Y1, Z1, X2, Y2, Z2));

// Метод читает данные от пользователя и возвращает преобразованные в число данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод принимает данные координат, находит расстояние между точками в 3-х мерном пространстве и 
// возвращает результат
double DistanceBetweenPoints3D(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    double distance = Math.Sqrt((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1)+(Z2-Z1)*(Z2-Z1));
    return distance;
} 

//Метод выводит данные пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}
