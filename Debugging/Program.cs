using System.Diagnostics;

int result = Fibonacci(5);
Console.WriteLine(result);

Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
Debug.WriteLine($"We are looking for the {num}th number");
static int Fibonacci(int num)
{
    int num1 = 0;
    int num2 = 1;
    int soma;

    for(int i = 2; i<= num; i++)
    {
        soma = num1 + num2;
        num1 = num2;
        num2 = soma;
        Debug.WriteLineIf(soma == 1, $"soma is 1, num1 is {num1}, num2 is {num2}");    
    }

    // If n2 is 5 continue, else break.
    Debug.Assert(num2 == 5, "The return value is not 5 and it should be.");
    return num == 0 ? num1 : num2;
}