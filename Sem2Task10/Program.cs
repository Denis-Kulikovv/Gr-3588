// Просим ввести 3х значное число
Console.WriteLine("Введите техзначное число ");
// Считываем данные с консоли
string? inputA = Console.ReadLine();

// Проверяем на пустые значения
if(inputA!=null)
{
    // Переводим в число
    int N = int.Parse(inputA);
    // Задаем условие 3х значности
    if(N<1000 && N>99)
    {
        int resultNumber = (N/10)%10;
        // Выводим результат в консоль
        Console.WriteLine(resultNumber);
    }// Если число не 3х значное просим ввести другое число
    else Console.WriteLine("Введите другое число");
}