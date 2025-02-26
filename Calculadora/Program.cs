// See https://aka.ms/new-console-template for more information
int num1, num2;
string operacao;
int resultado;

Console.WriteLine("Digite o primeiro número:");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número:");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("operação");
operacao = Console.ReadLine();

if (operacao == "*")
{
    resultado = num1 * num2;
    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
}

if (num2 == 0)
{
    Console.WriteLine("Não é possível dividir por zero");
}

if (operacao == "/")
{
    resultado = num1 / num2;
    Console.WriteLine($"O resultado da divisão é: {resultado}");

}