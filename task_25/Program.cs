// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
double power(double A, int B)
{
    double result = 1;
    int i = 1;
    while (i <= B)
    {
        result = result * A;
        i++;
    }
    return result;
}
try
{
    System.Console.Write("Введите число = ");
    double a = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите степень = ");
    int b = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine(power(a, b));
    System.Console.WriteLine(a + " в степени " + b + " = " + power(a, b));
}
catch
{
    System.Console.WriteLine("Пожалуйста,введете число");
}