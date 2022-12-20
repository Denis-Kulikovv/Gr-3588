// Задача №42 Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int inputNumber = ReadData("Enter number: ");

PrintData("Result: " + DegToBin(inputNumber));

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


void PrintData(string res)
{
    Console.WriteLine(res);
}

string DegToBin(int num)
{
    string outBin=String.Empty;
    while (num>0)
    {
        outBin = (num % 2) + outBin;
        num=num/2;
    }
    return outBin;
}



//string DecToBinN(int num)
//{
   // string binaryNum = Convert.ToString(num, 2);
   // return binaryNum;
//}

