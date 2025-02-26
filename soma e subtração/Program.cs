// See https://aka.ms/new-console-template for more information
int num1, num2;
string operacao;
int resultado;

Console.WriteLine("Bem vindo a calculadora");

Console.WriteLine("Digite o primeiro número:");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número:");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a operação");
operacao = Console.ReadLine();

if (operacao == "+")
{
    resultado = num1 + num2;
    Console.WriteLine($"O resultado da soma é: {resultado}");
}

if (operacao == "-")
{
    resultado = num1 - num2;
    Console.WriteLine($"O resultado da subtração é: {resultado}");
}