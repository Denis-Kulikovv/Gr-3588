// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

int[] array = GenArray(10, 100, 999);// Создаем массив заполненный случайными положительными трёхзначными числами 

Print1DArr(array); // Выводим его в консоль

int result = CountEven(array); // Вычисляем количество четных чисел в массиве

PrintData("Количество четных чисел в массиве : " + result); // Выводим результат

int[] GenArray(int len, int minValue, int maxValue) // Метод создает массив, в конкретном случае из 10 элементов, 3х
                                                    // значных случайных чисел 
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

int CountEven(int[] arr)// Метод принимает массив, проверяет каждый элемент на четность и накапливает количество четных элементов
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    { 
        if(arr[i]%2==0)
        res++;
    }
    return res;
} 