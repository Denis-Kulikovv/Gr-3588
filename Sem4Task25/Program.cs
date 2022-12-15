//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int ReadData(string msg) // Просим ввести число
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)// Метод выводит результат
{
    Console.WriteLine(res);
}

int Pow(int A, int B) // Метод вычисляет число А в степени Б
{
    int res = 1;
    for(int i=1;i<=B;i++)
    {
        res*=A;
    }
    return res;
}   

int A = ReadData("Введите число A");
int B = ReadData("Введите число B");


int res = Pow(A,B);

PrintData("Число " + A + " в степени " + B + " равно : " + res);
