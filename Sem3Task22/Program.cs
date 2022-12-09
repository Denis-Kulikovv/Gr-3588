int n = ReadData ("Введите число: ");

string line = LineBuilder(n);

Console.WriteLine(line);



// Метод читает данные от пользователя
int ReadData(string msg) 
{     
    Console.WriteLine(msg);    
    return int.Parse(Console.ReadLine() ?? "0");
}
string LineBuilder(int n)
{
    string line = "";
    string line2 = "";
    for (int i=1;i<n;i++)
    {
        line+=i+",";
        line2+=i*i+ ",";
    }
    line+= n;
    line2+= n*n;
    return line + "\n"+ line2;
}

