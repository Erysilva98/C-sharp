using System.Diagnostics;

int result = Fibonacci(5);
Console.WriteLine(result);

static int Fibonacci(int num)
{
    int num1 = 0;
    int num2 = 1;
    int soma;

    Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
    Debug.WriteLine($"we are looking for the {num}th number");

    for(int i = 2; i<= num; i++)
    {
        soma = num1 + num2;
        num1 = num2;
        num2 = soma;
        Debug.WriteLineIf(soma == 1, $"soma is 1, num1 is {num1}, num2 is {num2}");    
    }
    return num == 0 ? num1 : num2;
}