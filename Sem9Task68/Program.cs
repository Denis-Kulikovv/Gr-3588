// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// Чтение данных из консоли
uint ReadData(string line)
{
    Console.Write(line);
    uint number = uint.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(uint number)
{
    Console.WriteLine(number);
}

// Метод вычисления функции Аккермана
uint Akker(uint m, uint n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return Akker(m - 1, 1);
    else
        return Akker(m - 1, Akker(m, n - 1));
}

uint m = ReadData("Введите число m : ");
uint n = ReadData("Введите число n : ");
uint result = Akker(m, n);
PrintResult(result);

