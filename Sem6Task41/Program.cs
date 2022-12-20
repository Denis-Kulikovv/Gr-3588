// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int N = ReadData("Сколько чисел Вы хотите ввести? : ");

int res = CountPositivNum(N);

PrintData("Чисел больше 0 введено : " + res);

int ReadData(string msg)     // Метод считывает данные, введенные пользователем и возвращает число
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


void PrintData(string res)   // Метод выводит результат в консоль 
{
    Console.WriteLine(res);
}

int CountPositivNum(int N)  // Метод проверяет введеные числа на положительность
{
    int res = 0;
    while (N > 0)
    {
        int q = ReadData("Введите число : ");
        if (q > 0) res++;
        N = N - 1;
    }
    return res;
}