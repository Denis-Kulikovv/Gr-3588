// Метод читает данные от пользователя
int n = ReadData("Введите число");

string scroll = ScrollNumber(n);

Console.WriteLine(scroll);

// Метод выводит сообщение и преобразует данные от пользователя в число
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод определяет 2 строки с перечнем чисел до введенного пользователем числа и кубами этих чисел ниже
string ScrollNumber(int n)
{
    string line1 = "";
    string line2 = "";
    for (int i=1;i<n;i++)
    {
        line1+= i+",";
        line2+= i*i*i+",";
    }
    line1+= n;
    line2+= n*n*n;
    return line1+"\n"+line2;
}