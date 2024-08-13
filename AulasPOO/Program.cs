// See https://aka.ms/new-console-template for more information
using AulasPOO.uteis;
int opcao = 0, num1, num2;
do
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1) Somar");
    Console.WriteLine("2) Multiplicar");
    Console.WriteLine("3) Fatorial");
    Console.WriteLine("0) Sair");
    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 0:
            Console.WriteLine("Fim do Programa");
            break;
        case 1:
            LerDoisNumerosInteiros();
            var calc = new Calculadora();
            int resultado = calc.Soma(num1, num2);
            Console.WriteLine($"O resultado da soma de {num1} com {num2} é {resultado}");
            break;
        case 2:
            LerDoisNumerosInteiros();
            Console.WriteLine($"O resultado da multiplicação de {num1} por {num2} é {Calculadora.Multiplica(num1, num2)}");
            break;
        default:
            Console.WriteLine("Opcao Inválida");
            break;
    }
} while (opcao != 0);

void LerDoisNumerosInteiros()
{
    Console.WriteLine("Informe o primeiro número:");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo número:");
    num2 = int.Parse(Console.ReadLine());
}