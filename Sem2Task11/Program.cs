﻿// Находим случайное трехзначное число
int number = new Random().Next(100,1000);
// Выводим его в консоль
Console.WriteLine(number);
// Получаем первое
int A = number/100;
// Получаем второе
int B = number%10;
// Убираем среднее. Выходное число 2х значное, поэтому первое умножаем на 10 и прибавляем второе
int C = A*10 + B;
// Выводим результат в консоль
Console.WriteLine(C);



