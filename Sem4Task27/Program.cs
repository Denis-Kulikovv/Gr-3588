// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int ReadData(string msg) // Просим ввести число
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)// Метод выводит результат
{
    Console.WriteLine(res);
}


int CalcSumDigit(int num) // Метод вычисляет сумму цифр в числе
{
    int summ = 0;
    while(num>0)
    {
        summ+=num%10;
        num=num/10;
    }
    
    return summ;
}
int number = ReadData("Введите число ");

int result = CalcSumDigit(number);

PrintData("Сумма цифр в числе равна  "+ result);
