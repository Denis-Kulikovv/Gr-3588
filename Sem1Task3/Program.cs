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
// Выясняем является ли первое число квадратом второго
    if(num1 == num2*num2)
// Выводим сообщение    
    Console.WriteLine("Первое число является квадратом второго");
    
    else
    Console.WriteLine("Первое число не является квадратом второго");
}
