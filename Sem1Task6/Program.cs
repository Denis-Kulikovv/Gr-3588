// Просим ввести число
Console.WriteLine("Введите число");
// Считываем данные с консоли
string? inputA = Console.ReadLine();
// Проверяем на пустые значения
if(inputA!=null)
{// Переводим в число
    int numA = int.Parse(inputA);
// Вводим переменную и присваеваем ей значение остатка от деления на 2
    int numB = numA%2;
// Проверяем остаток и выводим данные
    if(numB==0)
    Console.WriteLine("ЧЕТНОЕ");
    else
    Console.WriteLine("НЕЧЕТНОЕ");
    
}