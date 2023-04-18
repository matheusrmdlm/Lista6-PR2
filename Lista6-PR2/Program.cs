using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6_PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     menu");
            Console.WriteLine("Exercicio 1");
            Console.WriteLine("Exercicio 2");
            Console.WriteLine("Exercicio 3");
            Console.WriteLine("Exercicio 4");
            Console.WriteLine("Exercicio 5");
            Console.WriteLine("Exercicio 6");
            int exec = int.Parse(Console.ReadLine());

            switch (exec)
            {
                case 1:
                    float total = 0;
                    int totalItens = 0;
                    for (; ; )
                    {
                        Console.WriteLine("informe a quantidade de compra(s)");
                        int quan = int.Parse(Console.ReadLine());

                        if (quan <= 0)
                            break;

                        Console.WriteLine("informe o valor da compra");
                        float compra = float.Parse(Console.ReadLine());

                        Console.WriteLine("\n\nO Program ira para quando a quantidade de comprar for informado der 0 \n\n");

                        totalItens += quan;
                        total += quan * compra;
                    }
                    Console.WriteLine("o total que ira pagar será " + total, " e a quantidade total de itens que você compro é " + totalItens);

                    break;

                case 2:

                    string[] nomesProdutos = new string[100];
                    int[] numItensProdutos = new int[100];
                    double[] precoCompraProdutos = new double[100];

                    int index = 0;

                    for (int i = 0; i < 100; i++)
                    {
                        Console.WriteLine("Digite o nome do produto (ou digite 'fim' para sair): ");
                        string nomeProduto = Console.ReadLine();

                        if (nomeProduto == "fim")
                        {
                            break;
                        }

                        Console.WriteLine("Digite o número de itens: ");
                        int numItens = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o preço de compra: ");
                        double precoCompra = double.Parse(Console.ReadLine());

                        nomesProdutos[index] = nomeProduto;
                        numItensProdutos[index] = numItens;
                        precoCompraProdutos[index] = precoCompra;

                        index++;
                    }

                    string nomeMaiorInvestimento = "";
                    double maiorInvestimento = double.MinValue;

                    string nomeMenorInvestimento = "";
                    double menorInvestimento = double.MaxValue;

                    for (int i = 0; i < index; i++)
                    {
                        double totalInvestido = numItensProdutos[i] * precoCompraProdutos[i];

                        if (totalInvestido > maiorInvestimento)
                        {
                            maiorInvestimento = totalInvestido;
                            nomeMaiorInvestimento = nomesProdutos[i];
                        }

                        if (totalInvestido < menorInvestimento)
                        {
                            menorInvestimento = totalInvestido;
                            nomeMenorInvestimento = nomesProdutos[i];
                        }
                    }

                    Console.WriteLine($"Nome do produto com maior investimento: {nomeMaiorInvestimento} ({maiorInvestimento:C})");
                    Console.WriteLine($"Nome do produto com menor investimento: {nomeMenorInvestimento} ({menorInvestimento:C})");

                    break;

                case 3:
                    Console.Write("Digite o número de avaliações: ");
                    int numAvaliacoes = int.Parse(Console.ReadLine());

                    double somaPesos = 0;
                    for (int i = 1; i <= numAvaliacoes; i++)
                    {
                        Console.Write($"Digite o peso da avaliação {i}: ");
                        double peso = double.Parse(Console.ReadLine());
                        somaPesos += peso;
                    }

                    if (somaPesos < 100)
                    {
                        Console.WriteLine($"A soma total dos pesos é insuficiente ({somaPesos}%).");
                    }
                    else if (somaPesos > 100)
                    {
                        Console.WriteLine($"A soma total dos pesos é excedente ({somaPesos}%).");
                    }
                    else
                    {
                        Console.WriteLine($"A soma total dos pesos é adequada ({somaPesos}%).");
                    }
                    break;

                case 4:
                    Console.Write("Digite a sigla do estado: ");
                    string sigla = Console.ReadLine().ToUpper();

                    string nomeEstado;

                    switch (sigla)
                    {
                        case "AC":
                            nomeEstado = "Acre";
                            break;
                        case "AL":
                            nomeEstado = "Alagoas";
                            break;
                        case "AP":
                            nomeEstado = "Amapá";
                            break;
                        case "AM":
                            nomeEstado = "Amazonas";
                            break;
                        case "BA":
                            nomeEstado = "Bahia";
                            break;
                        case "CE":
                            nomeEstado = "Ceará";
                            break;
                        case "DF":
                            nomeEstado = "Distrito Federal";
                            break;
                        case "ES":
                            nomeEstado = "Espírito Santo";
                            break;
                        case "GO":
                            nomeEstado = "Goiás";
                            break;
                        case "MA":
                            nomeEstado = "Maranhão";
                            break;
                        case "MT":
                            nomeEstado = "Mato Grosso";
                            break;
                        case "MS":
                            nomeEstado = "Mato Grosso do Sul";
                            break;
                        case "MG":
                            nomeEstado = "Minas Gerais";
                            break;
                        case "PA":
                            nomeEstado = "Pará";
                            break;
                        case "PB":
                            nomeEstado = "Paraíba";
                            break;
                        case "PR":
                            nomeEstado = "Paraná";
                            break;
                        case "PE":
                            nomeEstado = "Pernambuco";
                            break;
                        case "PI":
                            nomeEstado = "Piauí";
                            break;
                        case "RJ":
                            nomeEstado = "Rio de Janeiro";
                            break;
                        case "RN":
                            nomeEstado = "Rio Grande do Norte";
                            break;
                        case "RS":
                            nomeEstado = "Rio Grande do Sul";
                            break;
                        case "RO":
                            nomeEstado = "Rondônia";
                            break;
                        case "RR":
                            nomeEstado = "Roraima";
                            break;
                        case "SC":
                            nomeEstado = "Santa Catarina";
                            break;
                        case "SP":
                            nomeEstado = "São Paulo";
                            break;
                        case "SE":
                            nomeEstado = "Sergipe";
                            break;
                        case "TO":
                            nomeEstado = "Tocantins";
                            break;
                        default:
                            nomeEstado = "";
                            break;
                    }

                    if (nomeEstado == "")
                    {
                        Console.WriteLine("Sigla de estado inválida!");
                    }
                    else
                    {
                        Console.WriteLine($"O estado correspondente à sigla {sigla} é {nomeEstado}.");
                    }
                    break;


                case 5:
                    Console.Write("Digite um número inteiro entre 1 e 12: ");
                    int mes = int.Parse(Console.ReadLine());

                    string estacao = "";
                    switch (mes)
                    {
                        case 12:
                        case 1:
                        case 2:
                            estacao = "Inverno";
                            break;
                        case 3:
                        case 4:
                        case 5:
                            estacao = "Primavera";
                            break;
                        case 6:
                        case 7:
                        case 8:
                            estacao = "Verão";
                            break;
                        case 9:
                        case 10:
                        case 11:
                            estacao = "Outono";
                            break;
                        default:
                            Console.WriteLine("Mês inválido!");
                            return;
                    }

                    if (estacao == "Primavera" || estacao == "Outono")
                    {
                        Console.Write("O mês digitado pode ser " + estacao + ", porém ele ocorre em duas estações. ");
                        Console.Write("Digite '1' para " + estacao + " do início do mês até o dia 20, ou '2' para " + estacao + " do dia 21 até o final do mês: ");
                        int escolha = int.Parse(Console.ReadLine());
                        if (escolha == 1)
                        {
                            if (estacao == "Primavera")
                            {
                                estacao = "Primavera (início)";
                            }
                            else
                            {
                                estacao = "Outono (início)";
                            }
                        }
                        else if (escolha == 2)
                        {
                            if (estacao == "Primavera")
                            {
                                estacao = "Primavera (fim)";
                            }
                            else
                            {
                                estacao = "Outono (fim)";
                            }
                        }
                        else
                        {
                            Console.WriteLine("Escolha inválida!");
                            return;
                        }
                    }

                    Console.WriteLine("O mês digitado corresponde à estação: " + estacao);

                    break;

                case 6:
                    Console.Write("Digite seu peso (em kg): ");
                    double peso = double.Parse(Console.ReadLine());

                    Console.Write("Digite sua altura (em metros): ");
                    double altura = double.Parse(Console.ReadLine());

                    double imc = peso / (altura * altura);

                    Console.Write("Seu IMC é: " + imc + " - ");

                    if (imc < 18.5)
                    {
                        Console.WriteLine("Abaixo do peso");
                    }
                    else if (imc >= 18.5 && imc <= 24.9)
                    {
                        Console.WriteLine("Peso normal");
                    }
                    else if (imc >= 25.0 && imc <= 29.9)
                    {
                        Console.WriteLine("Sobrepeso");
                    }
                    else if (imc >= 30.0 && imc <= 34.9)
                    {
                        Console.WriteLine("Obesidade grau 1");
                    }
                    else if (imc >= 35.0 && imc <= 39.9)
                    {
                        Console.WriteLine("Obesidade grau 2");
                    }
                    else
                    {
                        Console.WriteLine("Obesidade grau 3 (mórbida)");
                    }

                    break;

                case 7:
                    Console.Write("Digite um número inteiro positivo: ");
                    int n = int.Parse(Console.ReadLine());

                    Console.WriteLine("Divisores de " + n + ":");
                    for (int i = 1; i <= n; i++)
                    {
                        if (n % i == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
            }
        }
    }
}