// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(int number)
{
    Console.WriteLine(number);
}
// Метод находит сумму натуральных элементов в промежутке между M и N
int SumBetwenMN(int M, int N)
{
    int outRes = 0;
    if (M >= N) return outRes + N;
    outRes += M + SumBetwenMN(M + 1, N);
    return outRes;
}

int number1 = ReadData("Введите число M : ");
int number2 = ReadData("Введите число N : ");
int result = number1 < number2 ? SumBetwenMN(number1, number2) : SumBetwenMN(number2, number1);
PrintResult(result);
