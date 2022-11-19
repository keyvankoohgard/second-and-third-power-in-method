// getting second and third power of a number in metho  \\
using System.Runtime.CompilerServices;

Console.WriteLine("please enter a number:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(calc(x));


double calc(int x)
{
    double result = Math.Pow(x, 2);
    return result;
}
Console.WriteLine(calcg(x));
double calcg(int x)
{
     double result_2 = Math.Pow(x, 3);
    return result_2;
}
