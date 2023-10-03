// 1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

int valor1;
int valor2;
float media;

Console.Write("Digite um valor inteiro: ");
valor1 = int.Parse(Console.ReadLine());
Console.Write("Digite um outro valor inteiro: ");
valor2 = int.Parse(Console.ReadLine());

media = (valor1 + valor2) / 2;

Console.WriteLine("A média dos valores é: " + media);

// 2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

Console.WriteLine("Calculadora de Média Aritmética");

int valor5, valor6, valor7, valor8;
float media2;

Console.Write("Digite o primeiro valor: ");
valor5 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
valor6 = int.Parse(Console.ReadLine());

Console.Write("Digite o terceiro valor: ");
valor7 = int.Parse(Console.ReadLine());

Console.Write("Digite o quarto valor: ");
valor8 = int.Parse(Console.ReadLine());

media2 = (valor5 + valor6 + valor7 + valor8) / 4;

Console.WriteLine($"A média dos valores é: {media}");

//3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
//si os valores de duas variáveis A e B.

int a = 9;
int b = 10;
int tmp = a; //backup do conteudo do a
a = b; //a recebe o conteudo do b
b = tmp; //o conteudo salvo em tmp vai para b

Console.Write("Digite uma frase qualquer: ");
string frase = Console.ReadLine();

Console.WriteLine("Você digitou....: " + frase.ToUpper());
Console.WriteLine("Esta frase tem " + frase.Length + " caracteres");

Console.Write("Digite algo para pesquisar: ");
string palavra = Console.ReadLine();

if (frase.Contains(palavra))
{
    Console.WriteLine(palavra + " aparece na frase");
    //bloco de instruções caso a palavra esteja na frase
}
else
{
    Console.WriteLine(palavra + " não aparece na frase");
    //bloco de instruções caso a palavra não esteja na frase
}

//4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
//forma AAAAMMDD e AAMMDD.Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

Console.WriteLine("Conversão de Data");

// Solicita a entrada da data no formato DDMMAAAA
Console.Write("Digite a data no formato DDMMAAAA: ");
string dataInput = Console.ReadLine();

// Verifica se a entrada tem o comprimento correto (8 caracteres)
if (dataInput.Length != 8)
{
    Console.WriteLine("Formato de data inválido. Use DDMMAAAA.");
    return;
}

// Divide a entrada em dia, mês e ano
string diaString = dataInput.Substring(0, 2);
string mesString = dataInput.Substring(2, 2);
string anoString = dataInput.Substring(4, 4);

// Converte as partes para inteiros
int dia = int.Parse(diaString);
int mes = int.Parse(mesString);
int ano = int.Parse(anoString);

// Imprime a data no formato AAAAMMDD
string dataAAAAMMDD = $"{ano:0000}{mes:00}{dia:00}";
Console.WriteLine($"Data no formato AAAAMMDD: {dataAAAAMMDD}");

// Imprime a data no formato AAMMDD
string dataAAMMDD = $"{ano % 100:00}{mes:00}{dia:00}";
Console.WriteLine($"Data no formato AAMMDD: {dataAAMMDD}");

//5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
//(medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível
//consumido para percorrê-la(medido em l).

Console.WriteLine("calculadora de consumo médio de combustível");

// solicita a entrada do usuário para a distância total e o volume de combustível consumido
Console.Write("digite a distância total percorrida (em km): ");
double distanciapercorrida = Convert.ToDouble(Console.ReadLine());

Console.Write("digite o volume de combustível consumido (em litros): ");
double volumecombustivel = Convert.ToDouble(Console.ReadLine());

// calcula o consumo médio em km/l
double consumomedio = distanciapercorrida / volumecombustivel;

//exibe o resultado
Console.WriteLine($"o consumo médio de combustível é de {consumomedio:f2} km/l");

//6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
//isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem
//de IPI(única) a ser acrescentada.

Console.WriteLine("Cálculo de Valor Total com IPI");

// Leitura dos dados para o parafuso A
Console.Write("Informe o código do parafuso A: ");
string codigoA = Console.ReadLine();

Console.Write("Informe a quantidade de peças do parafuso A: ");
int quantidadeA = int.Parse(Console.ReadLine());

Console.Write("Informe o valor unitário do parafuso A: ");
double valorUnitarioA = double.Parse(Console.ReadLine());

Console.Write("Informe a porcentagem de IPI para o parafuso A: ");
double ipiA = double.Parse(Console.ReadLine());

// Leitura dos dados para o parafuso B
Console.Write("Informe o código do parafuso B: ");
string codigoB = Console.ReadLine();

Console.Write("Informe a quantidade de peças do parafuso B: ");
int quantidadeB = int.Parse(Console.ReadLine());

Console.Write("Informe o valor unitário do parafuso B: ");
double valorUnitarioB = double.Parse(Console.ReadLine());

Console.Write("Informe a porcentagem de IPI para o parafuso B: ");
double ipiB = double.Parse(Console.ReadLine());

// Cálculo do valor total com IPI para o parafuso A
double valorTotalA = (quantidadeA * valorUnitarioA) * (1 + ipiA / 100.0);

// Cálculo do valor total com IPI para o parafuso B
double valorTotalB = (quantidadeB * valorUnitarioB) * (1 + ipiB / 100.0);

// Exibição dos resultados
Console.WriteLine($"Parafuso A (Código: {codigoA}):");
Console.WriteLine($"Quantidade: {quantidadeA}");
Console.WriteLine($"Valor Unitário: R$ {valorUnitarioA:F2}");
Console.WriteLine($"Valor Total com IPI: R$ {valorTotalA:F2}");
Console.WriteLine();

Console.WriteLine($"Parafuso B (Código: {codigoB}):");
Console.WriteLine($"Quantidade: {quantidadeB}");
Console.WriteLine($"Valor Unitário: R$ {valorUnitarioB:F2}");
Console.WriteLine($"Valor Total com IPI: R$ {valorTotalB:F2}");

//7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
//o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas.
//Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.

Console.WriteLine("Cálculo do Salário Total do Vendedor");

// Solicita a entrada do usuário para o número do vendedor
Console.Write("Informe o número do vendedor: ");
int numeroVendedor = int.Parse(Console.ReadLine());

// Solicita a entrada do usuário para o salário fixo do vendedor
Console.Write("Informe o salário fixo do vendedor: R$ ");
double salarioFixo = double.Parse(Console.ReadLine());

// Solicita a entrada do usuário para o total de vendas efetuadas
Console.Write("Informe o total de vendas efetuadas pelo vendedor: R$ ");
double totalVendas = double.Parse(Console.ReadLine());

// Solicita a entrada do usuário para o percentual de comissão sobre as vendas
Console.Write("Informe o percentual de comissão sobre as vendas (em %): ");
double percentualComissao = double.Parse(Console.ReadLine());

// Calcula o valor da comissão em reais
double comissao = (percentualComissao / 100) * totalVendas;

// Calcula o salário total do vendedor
double salarioTotal = salarioFixo + comissao;

// Exibe o número do vendedor e o salário total
Console.WriteLine($"Número do vendedor: {numeroVendedor}");
Console.WriteLine($"Salário Total do Vendedor: R$ {salarioTotal:F2}");

//8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit.
//A fórmula da conversão é F = (9 * C + 160) / 5.

Console.WriteLine("Conversão de Temperatura de Celsius para Fahrenheit");

// Solicita a entrada do usuário para a temperatura em graus Celsius
Console.Write("Digite a temperatura em graus Celsius: ");
double celsius = double.Parse(Console.ReadLine());

// Calcula a temperatura em graus Fahrenheit
double fahrenheit = (9 * celsius + 160) / 5;

// Exibe a temperatura em graus Fahrenheit
Console.WriteLine($"A temperatura em graus Fahrenheit é: {fahrenheit:F2} °F");

//9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
//do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis.
//Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00;
//se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
//Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
//da entrada e das duas prestações, de acordo com as regras acima.
//Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o
//conseqüente pagamento dos boletos das duas prestações.

Console.WriteLine("Cálculo do Valor da Entrada e das Prestações");

// Solicita a entrada do usuário para o valor da mercadoria
Console.Write("Digite o valor da mercadoria: R$ ");
double valorMercadoria = double.Parse(Console.ReadLine());

// Calcula o valor da entrada e das duas prestações
double entrada;
double prestacao;

if (valorMercadoria % 3 == 0)
{
    entrada = valorMercadoria / 3;
    prestacao = entrada;
}
else
{
    // Calcula a entrada maior
    entrada = Math.Floor(valorMercadoria / 3) + (valorMercadoria % 3);
    prestacao = Math.Floor(valorMercadoria / 3);
}

// Exibe o valor da entrada e das prestações
Console.WriteLine($"Valor da Entrada: R$ {entrada:F2}");
Console.WriteLine($"Valor das Prestações: R$ {prestacao:F2}");


//10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo
//para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que
//realizou o saque.Um possível critério seria o da “distribuição ótima” no sentido de que as 
//notas de menor valor fossem distribuídas em número mínimo possível. 
//Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
//uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
//Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas
//de acordo com o critério da “distribuição ótima”.

Console.WriteLine("Distribuição de Notas de Acordo com a Distribuição Ótima");

// Solicita a entrada do usuário para o valor da quantia solicitada
Console.Write("Digite o valor da quantia solicitada: R$ ");
int quantiaSolicitada = int.Parse(Console.ReadLine());

int[] notas = { 50, 20, 10, 5, 2, 1 }; // Valores das notas disponíveis

Console.WriteLine("Distribuição de notas:");

foreach (int nota in notas)
{
    if (quantiaSolicitada >= nota)
    {
        int quantidadeNotas = quantiaSolicitada / nota;
        quantiaSolicitada %= nota;
        Console.WriteLine($"{quantidadeNotas} nota(s) de R$ {nota},00");
    }
}

//11) Escreva um algoritmo para ler o número de eleitores de um município,
//o número de votos brancos, nulos e válidos. 
//Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.

Console.WriteLine("Cálculo do Percentual de Votos");

// Solicita a entrada do usuário para o número de eleitores, votos brancos, nulos e válidos
Console.Write("Digite o número total de eleitores: ");
int totalEleitores = int.Parse(Console.ReadLine());

Console.Write("Digite o número de votos brancos: ");
int votosBrancos = int.Parse(Console.ReadLine());

Console.Write("Digite o número de votos nulos: ");
int votosNulos = int.Parse(Console.ReadLine());

Console.Write("Digite o número de votos válidos: ");
int votosValidos = int.Parse(Console.ReadLine());

// Calcula os percentuais
double percentualBrancos = (double)votosBrancos / totalEleitores * 100;
double percentualNulos = (double)votosNulos / totalEleitores * 100;
double percentualValidos = (double)votosValidos / totalEleitores * 100;

// Exibe os resultados
Console.WriteLine($"Percentual de votos em branco: {percentualBrancos:F2}%");
Console.WriteLine($"Percentual de votos nulos: {percentualNulos:F2}%");
Console.WriteLine($"Percentual de votos válidos: {percentualValidos:F2}%");

//12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
//marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido
//dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.

//Fórmulas: Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia 

//Média do consumo = Total quilometragem/ quantidade de combustível gasto

//Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)

Console.WriteLine("Cálculo de Média de Consumo e Lucro Líquido");

// Solicita a entrada do usuário para a marcação do odômetro no início e no final do dia
Console.Write("Digite a marcação do odômetro no início do dia (em Km): ");
double odometroInicio = double.Parse(Console.ReadLine());

Console.Write("Digite a marcação do odômetro no final do dia (em Km): ");
double odometroFinal = double.Parse(Console.ReadLine());

// Solicita a entrada do usuário para o número de litros de combustível gasto
Console.Write("Digite o número de litros de combustível gasto no dia: ");
double litrosCombustivel = double.Parse(Console.ReadLine());

// Solicita a entrada do usuário para o valor total recebido dos passageiros
Console.Write("Digite o valor total recebido dos passageiros no dia (em R$): ");
double valorTotalRecebido = double.Parse(Console.ReadLine());

// Calcula o total de quilometragem
double totalQuilometragem = odometroFinal - odometroInicio;

// Calcula a média de consumo em Km/l
double mediaConsumo = totalQuilometragem / litrosCombustivel;

// Calcula o lucro líquido do dia
double lucroDia = valorTotalRecebido - (litrosCombustivel * 6.90);

// Exibe os resultados
Console.WriteLine($"Média de Consumo: {mediaConsumo:F2} Km/l");
Console.WriteLine($"Lucro Líquido do Dia: R$ {lucroDia:F2}");

//13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
//preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
//vendidas pelo vendedor, calcule e mostre: o salário do empregado


Console.WriteLine("Cálculo do Salário do Empregado");

// Solicita a entrada do usuário para o valor do salário mínimo
Console.Write("Digite o valor do salário mínimo mensal: R$ ");
double salarioMinimo = double.Parse(Console.ReadLine());

// Solicita a entrada do usuário para o preço de custo de cada bicicleta
Console.Write("Digite o preço de custo de cada bicicleta: R$ ");
double precoCustoBicicleta = double.Parse(Console.ReadLine());

// Solicita a entrada do usuário para o número de bicicletas vendidas pelo vendedor
Console.Write("Digite o número de bicicletas vendidas pelo vendedor: ");
int numeroBicicletasVendidas = int.Parse(Console.ReadLine());

// Calcula o salário do empregado
double salarioBase = 2 * salarioMinimo;
double comissao2 = numeroBicicletasVendidas * (0.15 * precoCustoBicicleta);
double salarioTotal2 = salarioBase + comissao2;

// Exibe o resultado
Console.WriteLine($"Salário do Empregado: R$ {salarioTotal2:F2}");


