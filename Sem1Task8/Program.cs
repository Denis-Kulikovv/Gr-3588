// Просим ввести число
Console.WriteLine("Введите число");
// Считываем данные с консоли
string? inputA = Console.ReadLine();
// Проверяем на пустые значения
if(inputA!=null)
{// Переводим в число
    int N = int.Parse(inputA);
// Вводим переменную равную 1 по условию задачи
    int startNumber = 1;

//Выходное значение
   string outResult = string.Empty;
// Запускаем цикл, проверяем все числа от единицы до N на четность
   while(startNumber<N)
   {
     if(startNumber%2==0)
    // Все четные заносим в результат      
      outResult = outResult + startNumber + ", ";
      startNumber++;
      
   }
// Проверяем само число N на четность, т.к. оно не входит в цикл.
   if(N%2==0) outResult = outResult + N;

   // Выводим данные в консоль 
   Console.WriteLine(outResult);
    
}
