// Вводим число
int number = int.Parse(Console.ReadLine()??"0");
Console.WriteLine(number);
// Вводим переменные делим на 7 и 23 проверяем остаток
int result1 = number%7;
int result2 = number%23;
// Задаем условие чтоб и от первого и от второго деления остаток был равен 0
if (result1 ==0 && result2==0)
{// Выводим в консоль
    Console.WriteLine("Да");
}
else
{// Выводим в консоль
    Console.WriteLine("Нет");
}

