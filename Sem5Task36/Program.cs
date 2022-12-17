// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = GenArray(12, -99, 99);// Создаем массив заполненный случайными числами 

Print1DArr(array); // Выводим его в консоль

int result = SumOdd(array); // Вычисляем сумму чисел на нечетных позициях в массиве

PrintData("Сумма элементов на нечетных позициях равна : " + result); // Выводим результат

int[] GenArray(int len, int minValue, int maxValue) // Метод создает массив из случайных чисел диапазона
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}


void Print1DArr(int[] arr)// Метод принимает массив и выводит его в консоль, каждый элемент через запятую
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

int SumOdd(int[] arr)// Метод принимает массив и накапливает сумму элементов на нечетных позициях
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    { 
        if(i%2>0)
        res+= arr[i];
    }
    return res;
} 