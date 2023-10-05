//1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
//Área do triangulo = (base * altura) / 2;
//Teste se a base ou a altura digitada não foi igual a zero. 

// Solicita ao usuário que insira o valor da base do triângulo.
Console.WriteLine("Digite o valor da base do triângulo:");
double baseTriangulo = double.Parse(Console.ReadLine());

// Solicita ao usuário que insira o valor da altura do triângulo.
Console.WriteLine("Digite o valor da altura do triângulo:");
double alturaTriangulo = double.Parse(Console.ReadLine());

// Verifica se a base e a altura são diferentes de zero.
if (baseTriangulo != 0 && alturaTriangulo != 0)
{
    // Calcula a área do triângulo usando a fórmula: Área = (base * altura) / 2.
    double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

    // Exibe a área calculada na tela.
    Console.WriteLine("A área do triângulo é: " + areaTriangulo);
}
else
{
    // Se a base ou a altura for igual a zero, exibe uma mensagem de erro.
    Console.WriteLine("A base e a altura não podem ser iguais a zero para calcular a área.");
}

//2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar.

// Solicita a entrada do usuário para um número
Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

// Verifica se o número é par ou ímpar
if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par.");
}
else
{
    Console.WriteLine($"O número {numero} é ímpar.");
}

//2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 
// Solicita ao usuário que insira um número.
Console.WriteLine("Digite um número: ");

// Lê o número fornecido pelo usuário e o converte para um valor inteiro.
int numero2 = int.Parse(Console.ReadLine());

// Verifica se o número é par ou ímpar.
if (numero2 % 2 == 0)
{
    // Se o resto da divisão por 2 for zero, o número é par.
    Console.WriteLine("O número " + numero2 + " é par.");
}
else
{
    // Se o resto da divisão por 2 não for zero, o número é ímpar.
    Console.WriteLine("O número " + numero2 + " é ímpar.");
}

//3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.

int quantidadeValores = 4;
int[] valores = new int[quantidadeValores];
int soma = 0;

// Solicita a entrada do usuário para os quatro valores
for (int i = 0; i < quantidadeValores; i++)
{
    Console.Write($"Digite o {i + 1}º valor: ");
    valores[i] = Convert.ToInt32(Console.ReadLine());
    soma += valores[i];
}

// Calcula a média
double media = (double)soma / quantidadeValores;

Console.WriteLine($"A média dos valores é: {media}");

Console.WriteLine("Valores superiores à média:");
// Mostra os valores que são superiores à média
for (int i = 0; i < quantidadeValores; i++)
{
    if (valores[i] > media)
    {
        Console.WriteLine(valores[i]);
    }
}

//4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
//Mostrar na tela qual dos professores tem o maior salário total.

// Solicita a quantidade de horas aula e o valor por hora do primeiro professor.
Console.WriteLine("Digite a quantidade de horas aula do primeiro professor:");
double horasAula1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor por hora do primeiro professor:");
double valorHora1 = double.Parse(Console.ReadLine());

// Solicita a quantidade de horas aula e o valor por hora do segundo professor.
Console.WriteLine("Digite a quantidade de horas aula do segundo professor:");
double horasAula2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor por hora do segundo professor:");
double valorHora2 = double.Parse(Console.ReadLine());

// Calcula o salário total de cada professor multiplicando a quantidade de horas aula pelo valor por hora.
double salarioTotal1 = horasAula1 * valorHora1;
double salarioTotal2 = horasAula2 * valorHora2;

// Compara os salários totais e determina qual professor tem o maior salário.
if (salarioTotal1 > salarioTotal2)
{
    Console.WriteLine("O primeiro professor tem o maior salário total: R$" + salarioTotal1);
}
else if (salarioTotal2 > salarioTotal1)
{
    Console.WriteLine("O segundo professor tem o maior salário total: R$" + salarioTotal2);
}
else
{
    Console.WriteLine("Ambos os professores têm o mesmo salário total: R$" + salarioTotal1);
}

//5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
//se a média das duas notas for maior ou igual a 7,0. 

//Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
//é a média entre a nota do exame e a média das 2 notas. 
//Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve 
//escrever “Reprovado”.

// Solicita a primeira nota do aluno.
Console.WriteLine("Digite a primeira nota do aluno:");
double nota1 = double.Parse(Console.ReadLine());

// Solicita a segunda nota do aluno.
Console.WriteLine("Digite a segunda nota do aluno:");
double nota2 = double.Parse(Console.ReadLine());

// Calcula a média das duas notas.
double media2 = (nota1 + nota2) / 2;

// Verifica se a média é maior ou igual a 7,0.
if (media2 >= 7.0)
{
    Console.WriteLine("Aprovado");
}
else
{
    // Caso a média seja menor que 7,0, solicita a nota do exame.
    Console.WriteLine("Digite a nota do exame:");
    double notaExame = double.Parse(Console.ReadLine());

    // Calcula a média final (média entre a nota do exame e a média das duas notas originais).
    double mediaFinal = (media2 + notaExame) / 2;

    // Verifica se a média final é maior ou igual a 5,0 e exibe o resultado.
    if (mediaFinal >= 5.0)
    {
        Console.WriteLine("Aprovado");
    }
    else
    {
        Console.WriteLine("Reprovado");
    }
}

//6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
//O programa deve calcular o Indice de Massa Corpórea (IMC), exibi - lo ao usuário e informar sua situação conforme a tabela.
//O cálculo do imc = peso / (altura * altura)

//IMC
//menor que 18                -> baixo peso
//maior que 18 e menor que 25 -> peso normal
//maior que 25 e menor que 30 -> sobrepeso
//maior que 30 e menor que 35 -> obesidade
//maior que 35                -> obesidade grau sério

// Solicita o nome da pessoa.
Console.WriteLine("Digite o nome da pessoa (em maiúsculo):");
string nome = Console.ReadLine();

// Solicita a altura da pessoa em metros.
Console.WriteLine("Digite a altura da pessoa (em metros):");
double altura = double.Parse(Console.ReadLine());

// Solicita o peso da pessoa em quilogramas.
Console.WriteLine("Digite o peso da pessoa (em quilogramas):");
double peso = double.Parse(Console.ReadLine());

// Calcula o IMC utilizando a fórmula: IMC = peso / (altura * altura).
double imc = peso / (altura * altura);

// Exibe o IMC calculado.
Console.WriteLine("O IMC da pessoa é: " + imc);

// Determina a situação da pessoa com base no IMC.
if (imc < 18)
{
    Console.WriteLine("Situação: Baixo Peso");
}
else if (imc < 25)
{
    Console.WriteLine("Situação: Peso Normal");
}
else if (imc < 30)
{
    Console.WriteLine("Situação: Sobrepeso");
}
else if (imc < 35)
{
    Console.WriteLine("Situação: Obesidade");
}
else
{
    Console.WriteLine("Situação: Obesidade Grau Sério");
}

//7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
//O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
//exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.

// Solicita uma frase ao usuário.
Console.WriteLine("Digite uma frase:");
string frase = Console.ReadLine();

// Solicita uma palavra de pesquisa ao usuário.
Console.WriteLine("Digite uma palavra para pesquisa:");
string palavraPesquisa = Console.ReadLine();

// Verifica se a palavra de pesquisa aparece na frase.
if (frase.Contains(palavraPesquisa))
{
    Console.WriteLine("A palavra \"" + palavraPesquisa + "\" encontra-se na frase.");
}
else
{
    Console.WriteLine("A palavra \"" + palavraPesquisa + "\" não se encontra na frase.");
}

//8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
//Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
//Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
//E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
//total de vendas. 

// Solicita ao usuário que insira o código do funcionário.
Console.WriteLine("Digite o código do funcionário:");
int codigo = int.Parse(Console.ReadLine());

// Solicita ao usuário que insira o nome do funcionário.
Console.WriteLine("Digite o nome do funcionário:");
string nome77 = Console.ReadLine();

// Solicita ao usuário que insira o salário base do funcionário.
Console.WriteLine("Digite o salário base do funcionário:");
double salarioBase = double.Parse(Console.ReadLine());

// Solicita ao usuário que insira o total de vendas do funcionário.
Console.WriteLine("Digite o total de vendas do funcionário:");
double totalVendas = double.Parse(Console.ReadLine());

// Calcula o aumento no salário final com base nas vendas.
double aumentoSalario = 0.0;

if (totalVendas > 500.0)
{
    aumentoSalario += totalVendas * 0.05; // 5% do total de vendas
}

if (totalVendas > 1000.0)
{
    aumentoSalario += totalVendas * 0.02; // 2% do total de vendas
}

if (totalVendas > 5000.0)
{
    aumentoSalario += totalVendas * 0.03; // 3% do total de vendas
}

// Calcula o salário final somando o salário base ao aumento.
double salarioFinal = salarioBase + aumentoSalario;

// Exibe os resultados na tela.
Console.WriteLine("Código do funcionário: " + codigo);
Console.WriteLine("Nome do funcionário: " + nome77);
Console.WriteLine("Salário base do funcionário: R$" + salarioBase);
Console.WriteLine("Total de vendas do funcionário: R$" + totalVendas);
Console.WriteLine("Salário final do funcionário: R$" + salarioFinal);

//9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
//diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
//Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
//Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.

//Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
//menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
//150, avisá-lo que será necessário adicionar 2 unidades de insulina.

// Solicita ao usuário que insira os valores de glicemia em jejum para 3 dias consecutivos.
Console.WriteLine("Digite o valor de glicemia em jejum para o dia 1:");
double glicemiaDia1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de glicemia em jejum para o dia 2:");
double glicemiaDia2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de glicemia em jejum para o dia 3:");
double glicemiaDia3 = double.Parse(Console.ReadLine());

// Verifica se algum dos valores está abaixo de 65 ou acima de 250.
if (glicemiaDia1 < 65 || glicemiaDia2 < 65 || glicemiaDia3 < 65)
{
    Console.WriteLine("Aviso: Risco de hipoglicemia!");
}
else if (glicemiaDia1 > 250 || glicemiaDia2 > 250 || glicemiaDia3 > 250)
{
    Console.WriteLine("Aviso: Risco de hiperglicemia!");
}
else
{
    Console.WriteLine("Os valores de glicemia estão dentro da faixa segura.");
}

//10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
//O programa deve mostrar os dados do atleta mais novo e mais alto.

// Solicita os dados do primeiro atleta.
Console.WriteLine("Dados do primeiro atleta:");
Console.Write("Nome: ");
string nome1 = Console.ReadLine();

Console.Write("Idade: ");
int idade1 = int.Parse(Console.ReadLine());

Console.Write("Altura (metros): ");
double altura1 = double.Parse(Console.ReadLine());

// Solicita os dados do segundo atleta.
Console.WriteLine("\nDados do segundo atleta:");
Console.Write("Nome: ");
string nome2 = Console.ReadLine();

Console.Write("Idade: ");
int idade2 = int.Parse(Console.ReadLine());

Console.Write("Altura (metros): ");
double altura2 = double.Parse(Console.ReadLine());

// Verifica qual atleta é mais novo e mais alto.
string atletaMaisNovo = (idade1 < idade2) ? nome1 : nome2;
string atletaMaisAlto = (altura1 > altura2) ? nome1 : nome2;

// Exibe os dados do atleta mais novo e mais alto.
Console.WriteLine("\nAtleta mais novo: " + atletaMaisNovo);
Console.WriteLine("Atleta mais alto: " + atletaMaisAlto);

//11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
//O programa deve exibir se a hora digitada está ou não válida. 
//Lembre que usaremos o padrão de hora com 24h, de 0 a 23.

// Solicita a hora ao usuário.
Console.Write("Digite a hora (0 a 23): ");
int hora = int.Parse(Console.ReadLine());

// Solicita os minutos ao usuário.
Console.Write("Digite os minutos (0 a 59): ");
int minutos = int.Parse(Console.ReadLine());

// Verifica se a hora e os minutos estão dentro dos intervalos válidos.
if (hora >= 0 && hora <= 23 && minutos >= 0 && minutos <= 59)
{
    Console.WriteLine("Hora válida!");
}
else
{
    Console.WriteLine("Hora inválida!");
}

//12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
//número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
//R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
//armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
//No final do processamento, exibir o salário total e o salário excedente do operário.

// Solicita o código do operário.

Console.Write("Digite o código do operário: ");
int codigo77 = int.Parse(Console.ReadLine());

// Solicita o número de horas trabalhadas pelo operário.
Console.Write("Digite o número de horas trabalhadas: ");
int numeroHoras = int.Parse(Console.ReadLine());

// Valor por hora de trabalho normal.
double valorPorHora = 10.0;

// Inicializa a variável para armazenar o salário total.
double salarioTotal = 0.0;

// Inicializa a variável para armazenar o salário excedente.
double salarioExcedente = 0.0;

// Verifica se o número de horas excede 50.
if (numeroHoras > 50)
{
    // Calcula as horas excedentes.
    int horasExcedentes = numeroHoras - 50;

    // Calcula o salário com base nas primeiras 50 horas.
    salarioTotal = 50 * valorPorHora;

    // Calcula o salário excedente com base nas horas excedentes.
    salarioExcedente = horasExcedentes * (valorPorHora * 2); // O dobro do valor por hora.

}
else
{
    // Se o número de horas for igual ou menor que 50, calcula o salário normal.
    salarioTotal = numeroHoras * valorPorHora;
}

// Exibe o salário total e o salário excedente.
Console.WriteLine("Salário Total: R$" + salarioTotal);
Console.WriteLine("Salário Excedente: R$" + salarioExcedente);

//13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
//seu peso ideal, utilizando as seguintes fórmulas:
//Para homens: (72.7 * h) - 58
//Para mulheres: (62.1 * h) - 44.7

Console.WriteLine("Digite a altura da pessoa (em metros):");
double altura99 = double.Parse(Console.ReadLine());

Console.WriteLine("Escolha o sexo da pessoa:");
Console.WriteLine("1 - Homem");
Console.WriteLine("2 - Mulher");
int escolhaSexo = int.Parse(Console.ReadLine());

double pesoIdeal = 0.0;

if (escolhaSexo == 1)
{
    // Fórmula para homens: (72.7 * altura) - 58
    pesoIdeal = (72.7 * altura99) - 58;
    Console.WriteLine("O peso ideal para um homem com " + altura99 + " metros de altura é: " + pesoIdeal + " kg");
}
else if (escolhaSexo == 2)
{
    // Fórmula para mulheres: (62.1 * altura) - 44.7
    pesoIdeal = (62.1 * altura99) - 44.7;
    Console.WriteLine("O peso ideal para uma mulher com " + altura99 + " metros de altura é: " + pesoIdeal + " kg");
}
else
{
    Console.WriteLine("Escolha de sexo inválida.");
}

//14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
//link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
//do arquivo usando este link (em minutos).

Console.WriteLine("Digite o tamanho do arquivo para download (em MB):");
double tamanhoArquivoMB = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a velocidade do link de Internet (em Mbps):");
double velocidadeMbps = double.Parse(Console.ReadLine());

// Convertendo a velocidade para MBps (1 byte = 8 bits)
double velocidadeMBps = velocidadeMbps / 8;

// Calculando o tempo aproximado de download em segundos
double tempoSegundos = tamanhoArquivoMB / velocidadeMBps;

// Convertendo o tempo para minutos
double tempoMinutos = tempoSegundos / 60;

Console.WriteLine("O tempo aproximado de download do arquivo é de " + tempoMinutos + " minutos.");

//15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
//da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
//e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
//Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

Console.WriteLine("Digite o tamanho da área a ser pintada em metros quadrados:");
double tamanhoAreaMetrosQuadrados = double.Parse(Console.ReadLine());

// Considerando que 1 litro de tinta cobre 3 metros quadrados.
double litrosNecessarios = tamanhoAreaMetrosQuadrados / 3.0;

// Considerando que a tinta é vendida em latas de 18 litros.
int latasNecessarias = (int)Math.Ceiling(litrosNecessarios / 18.0);

// Calculando o preço total.
double precoTotal = latasNecessarias * 80.0;

Console.WriteLine("Quantidade de latas de tinta necessárias: " + latasNecessarias);
Console.WriteLine("Preço total: R$" + precoTotal);

//16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
//na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
//enfrentar novamente em um novo jogo.
//ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
//ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
//plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.

Console.WriteLine("Digite o placar do jogo da primeira fase (Palmeiras x Boca Juniors):");
Console.Write("Palmeiras: ");
int placarPalmeiras = int.Parse(Console.ReadLine());

Console.Write("Boca Juniors: ");
int placarBoca = int.Parse(Console.ReadLine());

// Verifica se o time de fora ganhou por mais de 2 gols de diferença.
if (placarPalmeiras > placarBoca + 2 || placarPalmeiras < placarBoca - 2)
{
    Console.WriteLine("Palmeiras ou Boca já se classificaram para a próxima fase.");
}
else
{
    Console.WriteLine("Os dois times se enfrentarão em um novo jogo.");

    // Segunda partida.
    Console.WriteLine("\nSegundo jogo da primeira fase:");
    Console.Write("Boca Juniors: ");
    int placarBoca2 = int.Parse(Console.ReadLine());

    Console.Write("Palmeiras: ");
    int placarPalmeiras2 = int.Parse(Console.ReadLine());

    // Calcula o saldo de gols da primeira partida e da segunda partida.
    int saldoGols1 = placarPalmeiras - placarBoca;
    int saldoGols2 = placarBoca2 - placarPalmeiras2;

    // Verifica quem passou de fase com base nas duas partidas.
    if (saldoGols1 > saldoGols2)
    {
        Console.WriteLine("Palmeiras passou de fase.");
    }
    else if (saldoGols1 < saldoGols2)
    {
        Console.WriteLine("Boca Juniors passou de fase.");
    }
    else
    {
        Console.WriteLine("Os times empataram e irão para a prorrogação ou pênaltis.");
    }
}

//17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
//formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
//os lados iguais), isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes).

Console.WriteLine("Digite o tamanho dos lados do triângulo:");
Console.Write("Lado A: ");
double ladoA = double.Parse(Console.ReadLine());

Console.Write("Lado B: ");
double ladoB = double.Parse(Console.ReadLine());

Console.Write("Lado C: ");
double ladoC = double.Parse(Console.ReadLine());

// Verifica se os lados podem formar um triângulo.
bool formaTriangulo = (ladoA + ladoB > ladoC) && (ladoA + ladoC > ladoB) && (ladoB + ladoC > ladoA);

if (formaTriangulo)
{
    if (ladoA == ladoB && ladoB == ladoC)
    {
        Console.WriteLine("Os lados formam um triângulo equilátero.");
    }
    else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
    {
        Console.WriteLine("Os lados formam um triângulo isósceles.");
    }
    else
    {
        Console.WriteLine("Os lados formam um triângulo escaleno.");
    }
}
else
{
    Console.WriteLine("Os lados não podem formar um triângulo.");
}

//18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

Console.WriteLine("Digite três valores:");
Console.Write("Valor 1: ");
double valor1 = double.Parse(Console.ReadLine());

Console.Write("Valor 2: ");
double valor2 = double.Parse(Console.ReadLine());

Console.Write("Valor 3: ");
double valor3 = double.Parse(Console.ReadLine());

double maiorValor = valor1;

if (valor2 > maiorValor)
{
    maiorValor = valor2;
}

if (valor3 > maiorValor)
{
    maiorValor = valor3;
}

Console.WriteLine("O maior valor é: " + maiorValor);

//19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.

Console.WriteLine("Digite três valores:");
Console.Write("Valor 1: ");
double valor11 = double.Parse(Console.ReadLine());

Console.Write("Valor 2: ");
double valor22 = double.Parse(Console.ReadLine());

Console.Write("Valor 3: ");
double valor33 = double.Parse(Console.ReadLine());

// Coloca os valores em um array para facilitar a ordenação.
double[] valores99 = { valor1, valor2, valor3 };

// Ordena os valores em ordem crescente.
Array.Sort(valores99);

Console.WriteLine("Valores em ordem crescente:");
foreach (double valor in valores99)
{
    Console.WriteLine(valor);
}

double maiorValor99 = valores99[2]; // O último valor é o maior.

Console.WriteLine("O maior valor é: " + maiorValor99);


//20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
//plus: você pode gerar o número de forma randomica (função random c#).

Random random = new Random();
int numeroSecreto = random.Next(1, 101); // Gera um número secreto entre 1 e 100.

int tentativas = 3;

Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100.");

for (int i = 1; i <= tentativas; i++)
{
    Console.Write("Tentativa " + i + ": Digite um número: ");
    int tentativa = int.Parse(Console.ReadLine());

    if (tentativa == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o número secreto: " + numeroSecreto);
        break;
    }
    else if (tentativa < numeroSecreto)
    {
        Console.WriteLine("O número secreto é maior.");
    }
    else
    {
        Console.WriteLine("O número secreto é menor.");
    }

    if (i == tentativas)
    {
        Console.WriteLine("Você perdeu! O número secreto era: " + numeroSecreto);
    }
}

//21 - Crie um programa que permita que o usuário selecione uma unidade de medida de entrada (metros, centímetros, polegadas ou pés) e uma unidade de 
//medida de saída usando um menu com o comando switch case. O programa deve, em seguida, pedir ao usuário um valor de entrada e converter esse 
//valor para a unidade de saída selecionada.

Console.WriteLine("Conversor de Unidades de Medida");
Console.WriteLine("Selecione a unidade de medida de entrada:");
Console.WriteLine("1 - Metros");
Console.WriteLine("2 - Centímetros");
Console.WriteLine("3 - Polegadas");
Console.WriteLine("4 - Pés");

int unidadeEntrada = int.Parse(Console.ReadLine());

Console.WriteLine("Selecione a unidade de medida de saída:");
Console.WriteLine("1 - Metros");
Console.WriteLine("2 - Centímetros");
Console.WriteLine("3 - Polegadas");
Console.WriteLine("4 - Pés");

int unidadeSaida = int.Parse(Console.ReadLine());

Console.Write("Digite o valor de entrada: ");
double valorEntrada = double.Parse(Console.ReadLine());

double valorSaida = 0.0;

switch (unidadeEntrada)
{
    case 1: // Metros
        switch (unidadeSaida)
        {
            case 1:
                valorSaida = valorEntrada; // Metros para Metros (igual)
                break;
            case 2:
                valorSaida = valorEntrada * 100; // Metros para Centímetros
                break;
            case 3:
                valorSaida = valorEntrada * 39.37; // Metros para Polegadas
                break;
            case 4:
                valorSaida = valorEntrada * 3.281; // Metros para Pés
                break;
            default:
                Console.WriteLine("Unidade de saída inválida.");
                return;
        }
        break;
    case 2: // Centímetros
        switch (unidadeSaida)
        {
            case 1:
                valorSaida = valorEntrada / 100; // Centímetros para Metros
                break;
            case 2:
                valorSaida = valorEntrada; // Centímetros para Centímetros (igual)
                break;
            case 3:
                valorSaida = valorEntrada / 2.54; // Centímetros para Polegadas
                break;
            case 4:
                valorSaida = valorEntrada / 30.48; // Centímetros para Pés
                break;
            default:
                Console.WriteLine("Unidade de saída inválida.");
                return;
        }
        break;
    case 3: // Polegadas
        switch (unidadeSaida)
        {
            case 1:
                valorSaida = valorEntrada / 39.37; // Polegadas para Metros
                break;
            case 2:
                valorSaida = valorEntrada * 2.54; // Polegadas para Centímetros
                break;
            case 3:
                valorSaida = valorEntrada; // Polegadas para Polegadas (igual)
                break;
            case 4:
                valorSaida = valorEntrada / 12; // Polegadas para Pés
                break;
            default:
                Console.WriteLine("Unidade de saída inválida.");
                return;
        }
        break;
    case 4: // Pés
        switch (unidadeSaida)
        {
            case 1:
                valorSaida = valorEntrada / 3.281; // Pés para Metros
                break;
            case 2:
                valorSaida = valorEntrada * 30.48; // Pés para Centímetros
                break;
            case 3:
                valorSaida = valorEntrada * 12; // Pés para Polegadas
                break;
            case 4:
                valorSaida = valorEntrada; // Pés para Pés (igual)
                break;
            default:
                Console.WriteLine("Unidade de saída inválida.");
                return;
        }
        break;
    default:
        Console.WriteLine("Unidade de entrada inválida.");
        return;
}

Console.WriteLine("Valor convertido: " + valorSaida);
    