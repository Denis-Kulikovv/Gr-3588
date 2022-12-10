int numberA = ReadData("Введите число А ");

//int res1 = VariantSumSimple(numberA);
DateTime d1 = DateTime.Now;
int res2 = VariantSumGause(numberA);
Console.WriteLine(DateTime.Now-d1);
//PrintResult("Сумма чисел от одного до А равна (простой метод) : " + res1);

PrintResult("Сумма чисел от одного до А равна (Метод Гауса) : " + res2);





// Задача №26 Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// Запросданных у пользователя
int ReadData(string line)
{   // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP; // Возвращаем значение
}
// Метод вывода результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//int VariantSumSimple(int numA)
//{
    //int sumOfNumbers =0;
    //for(int i=1;i<=numA;i++)
   // {
      //  sumOfNumbers+=i;
      
  //  }
    //return sumOfNumbers;
//}

int VariantSumGause(int numA)
{
     int sumOfNumbers =0;
     sumOfNumbers = ((1+numA)*numA)/2;
     return sumOfNumbers;
}

