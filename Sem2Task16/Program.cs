int A = int.Parse(Console.ReadLine()??"0");
//Console.WriteLine(number1);
int B = int.Parse(Console.ReadLine()??"0");

bool R1 = (A/B==B);
bool R2 = (B/A==A);

if(R1) Console.WriteLine("А квадрат В");
if(R2) Console.WriteLine("В квадрат А");

if(!R2&&!R1) Console.WriteLine("Ни первое ни второе не является квадратом");

//void Test (int A, int B)
{
   // bool result = (A/B==B);
    //if(result==true) Console.WriteLine("А квадрат В");
    //else Console.WriteLine("А не квадрат В");
}

//int A = int.Parse(Console.ReadLine()??"0");
//int B = int.Parse(Console.ReadLine()??"0"); 

//TestSQRT(A,B);
//TestSQRT(B,A);



//Console.WriteLine("является ли одно число квадратом другого ?");
//Console.Write("Введите первое число: ");
//int firstNumber;
//bool isNumber = int.TryParse(Console.ReadLine(), out firstNumber);
//validate(isNumber);

//Console.Write("Введите второе число: ");
//int secondNumber;
//isNumber = int.TryParse(Console.ReadLine(), out secondNumber);
//validate(isNumber);

//Console.WriteLine(isSqrt(firstNumber,secondNumber)? "Да" : "Нет");

//void validate(bool isNumber){
//    if (!isNumber){
//        Console.WriteLine("Вы ввели не число, выход");
//       Environment.Exit(0);
//    }
//}

//bool isSqrt(int a, int b){
//    return (a*a == b) || (b*b == a) ;
//}
