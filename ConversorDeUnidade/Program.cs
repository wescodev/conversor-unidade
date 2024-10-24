Console.WriteLine("** CONVERSOR DE UNIDADE **");
Console.WriteLine();

float valorConvertido = 0;
int opcao = 0; // Inicializa a variável fora do loop

while (opcao != 7)
{
    // Mostra as opções de conversão a cada iteração
    Console.WriteLine("O que deseja converter?\n" +
        "\n[1] Quilometros para metros" +
        "\n[2] Metros para Quilometros" +
        "\n[3] Celsius para Fahrenheit" +
        "\n[4] Fahrenheit para Celcius" +
        "\n[5] Quilograma para libras" +
        "\n[6] Libras para Quilograma" +
        "\n[7] Sair");

    Console.Write("\nOpção: ");
    opcao = int.Parse(Console.ReadLine()); // Atualiza a opção a cada loop

    switch (opcao)
    {
        case 1:
            Console.Write("\nDigite quantos Quilometros serão convertidos: ");
            float valQuilo = float.Parse(Console.ReadLine());
            valorConvertido = valQuilo * 1000;
            Console.WriteLine($"{valQuilo}Km convertido para metros, é: {valorConvertido} Metros");
            break;
        case 2:
            Console.Write("\nDigite quantos Metros serão convertidos: ");
            float valMetros = float.Parse(Console.ReadLine());
            valorConvertido = valMetros / 1000;
            Console.WriteLine($"{valMetros} metros convertido para Quilometros, é: {valorConvertido} Quilometros");
            break;
        case 3:
            Console.Write("\nDigite quantos graus Celcius serão convertidos: ");
            float valCelcius = float.Parse(Console.ReadLine());
            valorConvertido = (valCelcius * 9 / 5) + 32;
            Console.WriteLine($"{valCelcius}° C convertido para Fahrenheit, é: {valorConvertido}° F");
            break;
        case 4:
            Console.Write("\nDigite quantos graus Fahrenheit serão convertidos: ");
            float valFahrenheit = float.Parse(Console.ReadLine());
            valorConvertido = (valFahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{valFahrenheit}° F convertido para Celcius, é: {valorConvertido}° C");
            break;
        case 5:
            Console.Write("\nDigite quantos Quilograma serão convertidos: ");
            float valQuilograma = float.Parse(Console.ReadLine());
            valorConvertido = valQuilograma * (float)2.2046;
            Console.WriteLine($"{valQuilograma}KG convertido para Libras, é: {valorConvertido} Libras");
            break;
        case 6:
            Console.Write("\nDigite quantas Libras serão convertidas: ");
            float valLibra = float.Parse(Console.ReadLine());
            valorConvertido = valLibra / (float)2.2046;
            Console.WriteLine($"{valLibra} Libras convertido para Quilograma, é: {valorConvertido} Kg");
            break;
        case 7:
            Console.WriteLine("\nObrigado por usar o conversor!!");
            break;
        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            break;
    }
}

