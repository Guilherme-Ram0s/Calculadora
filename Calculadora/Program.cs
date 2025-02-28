float num1, num2, resultado;
string operacao, usuario;

Console.WriteLine("gostaria de iniciar a calculadora (s/n)");
usuario = Console.ReadLine();

while (usuario == "s" || usuario == "S")
{
    Console.WriteLine("Digite um numero");
    num1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero");
    num2 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o número da operação \n 1 - ADIÇÃO \n 2 - SUBTRAÇÃO \n 3 - MULTIPLICAÇÃO \n 4 - DIVISÃO ");
    operacao = Console.ReadLine();

    switch (operacao)
    {
        case "1":
            resultado = num1 + num2;
            Console.WriteLine($"O resultado é  {resultado}");
            break;
        case "2":
            resultado = num1 - num2;
            Console.WriteLine($"O resultado é  {resultado}");
            break;
        case "3":
            resultado = num1 * num2;
            Console.WriteLine($"O resultado é {resultado}");
            break;
        case "4":
            if (num2 != 0)
            {
                resultado = num1 / num2;
                Console.WriteLine("resultado é " + resultado);
            }
            else
            {
                Console.WriteLine("não é possivel dividir por 0");
            }
            break;
        default:
            Console.WriteLine("Operação inválida");
            break;

    }
    Console.WriteLine("gostaria de continuar testando a calculadora? s/n");
    operacao = Console.ReadLine();
}
Console.WriteLine("obrigado por usar a calculadora");
