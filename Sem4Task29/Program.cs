// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int ReadData(string msg) // Метод принимает данные пользователя и возвращает преобразованные в число
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res, int[] arr) // Метод выводит данные
{
    Console.WriteLine(res);
    PrintArr(arr);
}

int[] GenArr(int minnum, int maxnum) // Метод принимает минимальную и максимальную границу диапазона и генерирует массив из 8 элементов. 
                                    //Значения берутся случайным образом из диапазона пользователя. 
{
    Random rnd = new Random();
    int[] arr = new int[8];
    for(int i=0;i<arr.Length;i++)
    {
        arr[i]=rnd.Next(minnum,maxnum);
    }
    return arr;
}

void PrintArr(int[] arr) // Метод строит структуру вывода массива
{
    Console.Write("[");
    for(int i=0;i<arr.Length-1;i++)
    {
        Console.Write(arr[i]+ ", "); 
        
    }
    Console.WriteLine(arr[arr.Length-1]+"]");    
}

int minnum = ReadData("Введите нижнюю границу массива ");
int maxnum = ReadData("Введите верхнюю границу массива ");

int[] arr = GenArr(minnum,maxnum);

PrintData("Cгенерированный массив :", arr);