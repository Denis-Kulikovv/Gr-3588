// Просим ввести число
Console.WriteLine("Введите число");
// Считываем с консоли и сразу переводим в число
int N = int.Parse(Console.ReadLine()??"0");
// Задаем условие наличия 3го числа
if(N>99)
{// Переводим его в массив
    Char[] Numbers = N.ToString().ToCharArray();
// Выводим в консоль 3е число, у него индекс 2 в массиве
    Console.WriteLine(Numbers[2]);
}
// Если нет 3го числа, выводим в консоль
else
   Console.WriteLine("Третьего числа нет");
