// See https://aka.ms/new-console-template for more information
using AulasPOO.uteis;
int opcao = 0, num1, num2;
do
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1) Somar");
    Console.WriteLine("2) Multiplicar");
    Console.WriteLine("3) Fatorial");
    Console.WriteLine("4) Sorteador");
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
        case 4:
            List<string> nomes = new List<string>() { "Marcelo Moura", "João Otávio", "Weber", "João Victor", "Aleixo", "Marcos Vinícius" };
            //Console.WriteLine("Lista original:");
            //foreach (string nome in nomes)
            //{
            //    Console.Write(nome);
            //}
            //Console.WriteLine("\n");
            List<string> sorteados = Sorteador.SortearNomes(nomes);
            int cont = 0;
            Console.WriteLine("Lista após sorteio:");
            foreach (string nome in sorteados)
            {
                Console.WriteLine($"Equipe {++cont}: {nome}");
            }
            
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

/*
 * Na pasta úteis crie uma classe chamada Sorteador que será capaz de sortear os nomes existentes em um vetor de nomes. A cada nome sorteado ele será armazenado em lista de nomes sorteados. Ao final imprimir o Lista Original e a nova Lista com os nomes sorteados.
 * Crie o respectivo código de teste para a classe Sorteador
 */