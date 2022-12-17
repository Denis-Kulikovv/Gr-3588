// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double min = double.MaxValue;// Задаем 2 переменные, в которые запишем максимальное и минимальное значение с помощью 
double max = double.MinValue;// метода DifMinMax

double[] array = GenArray(5, -2, 2);// Создаем массив вещественных чисел, заполненный случайными числами 

Print1DArr(array); // Выводим его в консоль

DifMinMax(array); // Находим максимальное и минимальное значение элементов

PrintData("Разница между максимальным и минимальным элементом равна : "+ (max-min)); // Выводим результат



double[] GenArray(int len, int minValue, int maxValue) // Метод создает массив из случайных чисел диапазона
{
    double[] arr = new double[len];
    for (int i=0;i<arr.Length;i++)
    {
        arr[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    }
    return arr;
}


void Print1DArr(double[] arr)// Метод принимает массив и выводит его в консоль, каждый элемент через запятую
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}



void PrintData(string res)// Метод выводит результат в консоль
{
    Console.WriteLine(res);
}


void DifMinMax(double[] arr)// Метод принимает массив и находит элемент с максимальным и минимальным значением
{
    for (int i = 0; i < arr.Length; i++)
    {   
        if(arr[i]>max) max=arr[i];
        if(arr[i]<min) min=arr[i];
        
    }
    
} 




