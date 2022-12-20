// Задача №39 Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
int[] arr = GenArray(20,1,100);
Console.WriteLine("Исходный массив ");
Print1DArr(arr);

int[] copyArr = SwapNewArray(arr);
Console.WriteLine("Новый массив перевернутый методом SwapNewArray ");
Print1DArr(copyArr);
Console.WriteLine("Исходный массив ");
Print1DArr(arr);

int[] copyArrTwo = SwapArray(arr);
Console.WriteLine("Новый массив перевернутый методом SwapArray ");
Print1DArr(copyArrTwo);
Console.WriteLine("Исходный массив ");
Print1DArr(arr);

void Print1DArr(int[] arr)// Метод принимает массив и выводит его в консоль, каждый элемент через запятую
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}


int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue);
    }
    return outArray;
}

int[] SwapArray(int[] arr)
{
    int bufElement = 0;
    for (int i = 0; i < arr.Length/2-1-i; i++)
    {
        bufElement = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = arr[i];
        arr[i] = bufElement;
    }
    return arr;
    

} 


int[] SwapNewArray(int[] arr)
{
        int[] outArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
        outArr[i] = arr[arr.Length-1-i];
        
        }
        return outArr;

}
