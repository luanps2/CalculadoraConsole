Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Bem-vindo ao meu primeiro programa, uma calculadora básica!");
Console.WriteLine("-----------------------------------------------------------");

//Declaração das váriaveis do programa, onde serão armazenados os dados para executar as operações
double numero1;
double numero2;
int operador;
string sinal = "";
double resultado = 0;

//WriteLine: Texto que irá aparecer para o usuário(o "\n" serva para fazer uma quebra de linha, é como se você desse um Enter.
Console.WriteLine("Escolha uma operação matemática: ");
Console.WriteLine("-----------------------------------------------------------------------");
Console.WriteLine("1 - Adição(+) \n2 - Subtração(-) \n3 - Multiplicação(*) \n4 - Divisão(/) \n5 - Sair");
Console.WriteLine("-----------------------------------------------------------------------");

//ReadLine: permite que o usuário digite algum texto na tela(a váriavel "operador" na frente faz com que o que o usuário digitar ficará armazenado na variavel)
operador = int.Parse(Console.ReadLine());

//utiliza a estrutura condicional if(também conhecida como "SE") para fazer o calculo escolido pelo usuário
if (operador == 5)
{
    Console.WriteLine("Obrigado, até a próxima");
}
else if (operador < 1 || operador > 5)
{
    Console.WriteLine("Opção Inválida!");
}
else
{
    //Solicita ao usuário que digite o segundo número da operação e armazene na váriavel "numero1"
    Console.WriteLine("Digite o primeiro número da operação: ");
    numero1 = double.Parse(Console.ReadLine());

    //Solicita ao usuário que digite o segundo número da operação e armazene na váriavel "numero2"
    Console.WriteLine("Digite o segundo número da operação: ");
    numero2 = double.Parse(Console.ReadLine());

    if (operador == 1)
    {
        sinal = "+";
        resultado = numero1 + numero2; //Armazena na váriavell resultado a soma dos dois números
    }
    else if (operador == 2)
    {
        sinal = "-";
        resultado = numero1 - numero2; //Armazena na váriavell resultado a subtração dos dois números
    }
    else if (operador == 3)
    {
        sinal = "*";
        resultado = numero1 * numero2; //Armazena na váriavell resultado a multiplicação dos dois números
    }
    else if (operador == 4)
    {
        sinal = "/";
        resultado = numero1 / numero2; //Armazena na váriavell resultado a divisão dos dois números
    }

    //exibe o resultado na tela.
    Console.WriteLine("-----------------------");
    Console.WriteLine($"Resultado: {numero1} {sinal} {numero2} = {resultado}");
    Console.WriteLine("-----------------------");
    Console.WriteLine(" ");
    Console.WriteLine("Obrigado, Até a próxima");

}





