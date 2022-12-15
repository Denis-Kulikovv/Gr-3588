// S

int positivsum = 0;
int negativsum = 0;

int[] testArr=GenArr(12, -9, 9);
PrintData("Cумма положительных чисел в масстве равна ", positivsum);
PrintData("Cумма отрицательных чисел в масстве равна ", negativsum);
NegativPositivSum(testArr);

int[] GenArr(int len, int minValue, int maxValue) 
{   Random rnd = new Random();
    int[] arr = new int[len];
    for(int i=0;i<arr.Length;i++)
    {
        arr[i]=new Random().Next(minValue,maxValue+1);
    }
    return arr;
}
void PrintData(string res, int value)
{
    Console.WriteLine(res+value);

}

void NegativPositivSum(int[] arr)
{
    for(int i=0;i<arr.Length;i++)
    {  
        if(arr[i]>0)
        {
            positivsum+=arr[i];
        }
        else
        {
            negativsum+=arr[i];
        }
       
    }
    

}
