﻿// Просим ввести число
//Console.WriteLine("Введите координату Х ");
//int coordX = int.Parse(Console.ReadLine()??"0");

//Console.WriteLine("Введите координату Y ");
//int coordY = int.Parse(Console.ReadLine()??"0");

//PrintQuterTest();


int coordX = ReadData("Введите координату Х ");
int coordY = ReadData("Введите координату Y ");

PrintQuterTest();


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine("msg ");
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод определяет четверть по координатам
void PrintQuterTest()
{
    if(coordX>0&&coordY>0) Console.WriteLine("Точка в четверти 1 ");
    if(coordX>0&&coordY<0) Console.WriteLine("Точка в четверти 2 ");
    if(coordX<0&&coordY<0) Console.WriteLine("Точка в четверти 3 ");
    if(coordX<0&&coordY>0) Console.WriteLine("Точка в четверти 4 ");

}

