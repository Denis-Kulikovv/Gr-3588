// Метод читает данные от пользователя
int numbers = ReadData("Введите пятизначное число");
// Метод проверяет является ли число палиндромом 
bool result = PalinTest(numbers);
// Выводим результат в консоль
Console.WriteLine(result);

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine("Введите пятизначное число");
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод проверяет является ли число палиндромом
bool PalinTest(int numbers)
{
    bool result = false;
    result = (numbers/10000==numbers%10&&(numbers/1000)%10==(numbers/10)%10);

    return result;
} 



