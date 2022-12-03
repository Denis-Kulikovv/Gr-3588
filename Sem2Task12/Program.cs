int A = int.Parse(Console.ReadLine()??"0");
int B = int.Parse(Console.ReadLine()??"0");
int R = B%A;
// Задаем условие равен ли остаток 0
if(R==0)
{
   Console.WriteLine("Второе число делится на первое без остатка"); 
} 

else
   Console.WriteLine("Второе число делится на первое c остаткoм " + R);