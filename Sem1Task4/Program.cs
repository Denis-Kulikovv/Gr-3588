// Просим ввести 3 числа
Console.WriteLine("Введите три числа ");
// Считываем данные с консоли
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineС = Console.ReadLine();
// Проверяем на пустые значения
if(inputLineA!=null&&inputLineB!=null&&inputLineС!=null)
{
// Переводим в числа
    int num1 = int.Parse(inputLineA);
    int num2 = int.Parse(inputLineB);
    int num3 = int.Parse(inputLineС);
// Вводим дополнительную переменную и присваиваем ей значение 
    int maxNumber = num1;
// Сравниваем num2 c maxNumber. Если num2 больше, то записываем num2 в maxNumber
    if(num2>maxNumber) maxNumber = num2;
           
// Теперь сравниваем num3. Если num3 больше, то записываем num3 в maxNumber
    if(num3>maxNumber) maxNumber = num3;
    
    Console.WriteLine(maxNumber);
}
