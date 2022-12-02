// Просим ввести 2 числа
Console.WriteLine("Введите два числа ");
// Считываем данные с консоли
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
// Проверяем на пустые значения
if(inputLineA!=null&&inputLineB!=null)
{// Переводим в число
    int num1 = int.Parse(inputLineA);
    int num2 = int.Parse(inputLineB);
// Сравниваем эти числа
    if(num1>num2)
// Выводим большее из них    
    Console.WriteLine(num1);
    
    else
    Console.WriteLine(num2);
}

