//Задача 27: Напишите программу, которая принимает на вход число и
// выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int charSum(double N)
{
    
    double mutable = N;  
    int summary = 0;
    while (mutable % 1 > 0)   
    {
        mutable = mutable * 10;
    }
    int countOfCharInNumber = Convert.ToInt32(Math.Log(mutable, 10)); 
    if (countOfCharInNumber < 1)
    {
        countOfCharInNumber++;
    }   
    long[] massiveOfNumber = new long[countOfCharInNumber];
    for (int i = 0; i < countOfCharInNumber; i++)   
    {
        massiveOfNumber[i] = Convert.ToInt64(mutable) / Convert.ToInt32(Math.Pow(10, i)) % 10;
        summary = summary + Convert.ToInt32(massiveOfNumber[i]);
    }
    return summary;
}
try
{
    System.Console.Write("Введите число = ");
    double a = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine(charSum(a));
}
catch
{
    System.Console.WriteLine("Пожалуйста, введите число");
}