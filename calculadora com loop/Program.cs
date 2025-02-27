float num1, num2, resultado;
string operacao, usuario;


Console.WriteLine("Bem vindo a calculadora. \n Gostaria de fazer um calculo? - S/N");
usuario = Console.ReadLine();
do
{
    Console.WriteLine("Digite a operação desejada: +, -, *, /");
    operacao = Console.ReadLine();

    switch (operacao)
    {
        case "+":
            Console.WriteLine("Digite o primeiro número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = float.Parse(Console.ReadLine());
            resultado = num1 + num2;
            Console.WriteLine("O resultado da soma é: " + resultado);
            break;
        case "-":
            Console.WriteLine("Digite o primeiro número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = float.Parse(Console.ReadLine());
            resultado = num1 - num2;
            Console.WriteLine("O resultado da subtração é: " + resultado);
            break;
        case "*":
            Console.WriteLine("Digite o primeiro número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = float.Parse(Console.ReadLine());
            resultado = num1 * num2;
            Console.WriteLine("O resultado da multiplicação é: " + resultado);
            break;
        case "/":

            Console.WriteLine("Digite o primeiro número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = float.Parse(Console.ReadLine());
            resultado = num1 / num2;
            Console.WriteLine("O resultado da divisão é: " + resultado);
            break;
            if (num2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero");
                break;
            }
    }
} while (usuario == "s" || usuario == "S");