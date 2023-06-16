using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exercicio;
            //Menu Interface
           
            Console.WriteLine("Escolha o número do exercício da lista a seguir:");
            Console.WriteLine("\n 1) Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas,\n o valor que recebe por hora e calcula o salário desse funcionário.\n A seguir, mostre o número e o salário do funcionário, com duas casas decimais\n");
            Console.WriteLine("\n 2) Fazer um programa para ler quatro valores inteiros A, B, C e D.\r\n         A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula:\r\n         DIFERENCA = (A * B - C * D)");
            Console.WriteLine("\n 3) Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o\r\n        código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago");
            Console.WriteLine("\n 4) Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.Em seguida, calcule e\r\n        mostre:\r\n        a) a área do triângulo retângulo que tem A por base e C por altura.\r\n        b) a área do círculo de raio C. (pi = 3.14159)\r\n        c) a área do trapézio que tem A e B por bases e C por altura.\r\n        d) a área do quadrado que tem lado B.\r\n        e) a área do retângulo que tem lados A e B.");
            Console.WriteLine("\n 5) Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não");
            Console.WriteLine("\n 6) Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.");
            Console.WriteLine("\n 7) Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem \"Sao Multiplos\" ou \"Nao sao Multiplos\",\n indicando se os valores lidos são múltiplos entre si.\r\n Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.");
            Console.WriteLine("\n 8) Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode\r\n começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas");
            Console.WriteLine("\n 9) Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A\r\n seguir, calcule e mostre o valor da conta a pagar.");
            Console.WriteLine("\n");
            Console.WriteLine(" Código |  Especificação  |  Preço ");
            Console.WriteLine("   1    | Cachorro-Quente | R$ 4,00");
            Console.WriteLine("   2    |    X-Salada     | R$ 4,50");
            Console.WriteLine("   3    |    X-Bacon      | R$ 5,00");
            Console.WriteLine("   4    | Torrada Simples | R$ 2,00");
            Console.WriteLine("   5    |   Refrigerante  | R$ 1,50");
            Console.WriteLine("\n");
            Console.WriteLine("\n 10) Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos\r\n seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em\r\n nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.");
            Console.WriteLine("\n 11) Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas\r\n de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o\r\n ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).\r\n Se o ponto estiver na origem, escreva a mensagem “Origem”.\r\n Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a\r\n situação.");
            Console.WriteLine("        |Y       ");
            Console.WriteLine("        |       ");
            Console.WriteLine("  Q2    |   Q1  ");
            Console.WriteLine("        |       X");
            Console.WriteLine("--------|--------");
            Console.WriteLine("        |       ");
            Console.WriteLine("  Q3    |  Q4   ");
            Console.WriteLine("        |       ");
            Console.WriteLine("\n 12) Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem\r\nque nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem\r\nqualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.\r\nLeia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e\r\nmostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.");
            Console.WriteLine("            Renda            | Imposto de Renda");
            Console.WriteLine(" de R$ 0,00 até R$ 2000,00   |     Isento");
            Console.WriteLine("de R$ 2000,01 até R$ 3000,00 |       8%");
            Console.WriteLine("de R$ 3000,01 até R$ 4500,00 |       18%");
            Console.WriteLine("     acima de 4500,01        |       28% ");
            Console.Write("Número do Exercício: ");
            exercicio = int.Parse(Console.ReadLine());
            //Codigo dos Exercicios
            
            switch (exercicio)
                
                {
                case 1:
                Console.Clear();
                Console.WriteLine("\n 1) Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas,\n o valor que recebe por hora e calcula o salário desse funcionário.\n A seguir, mostre o número e o salário do funcionário, com duas casas decimais\n");
                int id;
                int horasTrabalhadas;
                double vlrPorHora;
                double salario;
                Console.WriteLine("Informe a ID do funcionário: ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a quantidade de horas trabalhadas:");
                horasTrabalhadas = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor por hora trabalhada: ");
                vlrPorHora = double.Parse(Console.ReadLine());
                salario = horasTrabalhadas * vlrPorHora;
                Console.WriteLine($"ID Funcionário: {id}");
                break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("2) Fazer um programa para ler quatro valores inteiros A, B, C e D.\r\n         A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula:\r\n         DIFERENCA = (A * B - C * D)");
                    
                    int a, b, c, d;
                    int diferenca;
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    c = int.Parse(Console.ReadLine());
                    d = int.Parse(Console.ReadLine());
                    diferenca = (a * b - c * d);
                    Console.WriteLine($"A diferença é de: {diferenca}");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("\n 3) Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o\r\n        código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago");
                    string peca1;
                    string peca2;
                    double totalp1;
                    double totalp2;
                    double total;

                    peca1 = Console.ReadLine();
                    peca2 = Console.ReadLine();
                    string[] p1 = peca1.Split();
                    string[] p2 = peca2.Split();
                    totalp1 = double.Parse(p1[1]) * double.Parse(p1[2]);
                    totalp2 = double.Parse(p2[1]) * double.Parse(p2[2]);
                    total = totalp1 + totalp2;
                    Console.WriteLine($"O valor total é de: {total}");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("\\n 4) Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.Em seguida, calcule e\\r\\n        mostre:\\r\\n        a) a área do triângulo retângulo que tem A por base e C por altura.\\r\\n        b) a área do círculo de raio C. (pi = 3.14159)\\r\\n        c) a área do trapézio que tem A e B por bases e C por altura.\\r\\n        d) a área do quadrado que tem lado B.\\r\\n        e) a área do retângulo que tem lados A e B.\");\r\n");
                    double aEx4, bEx4, cEx4, areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;
                    double pi = 3.14159;
                    Console.WriteLine("Valor A: ");
                    aEx4 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Valor B: ");
                    bEx4 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Valor C: ");
                    cEx4 = double.Parse(Console.ReadLine());
                    areaTriangulo = (aEx4 * cEx4) / 2;
                    areaCirculo = pi * (cEx4 * cEx4);
                    areaTrapezio = ((aEx4 + bEx4) / 2) * cEx4;
                    areaQuadrado = Math.Pow(bEx4, 2);
                    areaRetangulo = aEx4 * bEx4;

                    Console.WriteLine($"A area do triangulo é: {areaTriangulo.ToString("F3")}");
                    Console.WriteLine($"A area do circulo é: {areaCirculo.ToString("F3")}");
                    Console.WriteLine($"A area do trapézio é: {areaTrapezio.ToString("F3")}");
                    Console.WriteLine($"A area do quadrado é: {areaQuadrado.ToString("F3")}");
                    Console.WriteLine($"A area do retangulo é: {areaRetangulo.ToString("F3")}");
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("\n 5) Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não");
                    int valorEx5;
                    Console.WriteLine("Digite o valora ser verificado: ");
                    valorEx5 = int.Parse(Console.ReadLine());
                    if (valorEx5 >= 0)
                    {
                        Console.WriteLine("O valor é positivo");
                    }
                    else
                    {
                        Console.WriteLine("O valor é negativo");
                    }
               break;
                case 6:
                Console.Clear();
                Console.WriteLine("\n 6) Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.");
                    int valorEx6;
                    Console.WriteLine("Digite o número: ");
                    valorEx6 = int.Parse(Console.ReadLine());
                    if (valorEx6 % 2 == 0)
                    {
                        Console.WriteLine("O valor é par");

                    }
                    else
                    {
                        Console.WriteLine("O valor é Impar");
                    }
                    break;
              case 7:
                    Console.Clear();
                    Console.WriteLine("\n 7) Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem \"Sao Multiplos\" ou \"Nao sao Multiplos\",\n indicando se os valores lidos são múltiplos entre si.\r\n Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.");

                    int aEx7, bEx7, cEx7, dEx7;
                    Console.WriteLine("Insira os Valores");
                    aEx7 = int.Parse(Console.ReadLine());
                    bEx7 = int.Parse(Console.ReadLine());
                    cEx7 = aEx7 / bEx7;
                    dEx7 = bEx7 / aEx7;
                    if (aEx7 % bEx7 == 0 || bEx7 % aEx7 == 0)
                    {
                        Console.WriteLine($"são multiplos");
                    }
                    else
                    {
                        Console.WriteLine($"Não são multiplos");
                    }
                    break;

             case 8:
                    Console.Clear();
                    Console.WriteLine("\n 8) Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode\r\n começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas");
                    int inicio, fim, duracao;
                    Console.WriteLine("Informe a hora de inicio do jogo: ");
                    inicio = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a hora do fim do jogo: ");
                    fim = int.Parse(Console.ReadLine());

                    if (inicio < fim)
                    {
                        duracao = fim - inicio;
                        Console.WriteLine($"O jogo durou {duracao} horas");
                    }
                    else if (inicio > fim)
                    {
                        fim = fim + 24;
                        duracao = inicio - fim;
                        duracao = duracao * -1;
                        Console.WriteLine($"O jogo durou {duracao} horas");
                    }
                    else if (inicio == fim)
                    {
                        Console.WriteLine("O jogo durou 24 horas");
                    }
             break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("\n 9) Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A\r\nseguir, calcule e mostre o valor da conta a pagar.");
                    Console.WriteLine("\n");
                    Console.WriteLine(" Código |  Especificação  |  Preço ");
                    Console.WriteLine("   1    | Cachorro-Quente | R$ 4,00");
                    Console.WriteLine("   2    |    X-Salada     | R$ 4,50");
                    Console.WriteLine("   3    |    X-Bacon      | R$ 5,00");
                    Console.WriteLine("   4    | Torrada Simples | R$ 2,00");
                    Console.WriteLine("   5    |   Refrigerante  | R$ 1,50");
                    Console.WriteLine("\n");

                    int codigoEx9, quantidadeEx9;
                    double valorTotalEx9;
                    Console.Write("Informe o código do produto: ");
                    codigoEx9 = int.Parse(Console.ReadLine());
                    Console.Write("Informe a quantidade do do produto: ");
                    quantidadeEx9 = int.Parse(Console.ReadLine());

                    if(codigoEx9 == 1)
                    {
                        valorTotalEx9 = quantidadeEx9 * 4.00;
                        Console.WriteLine($"O valor total é de: {valorTotalEx9.ToString("F2")}");
                    }
                    else if (codigoEx9 == 2)
                    {
                        valorTotalEx9 = quantidadeEx9 * 4.50;
                        Console.WriteLine($"O valor total é de: {valorTotalEx9.ToString("F2")}");
                    }
                    else if (codigoEx9 == 3)
                    {
                        valorTotalEx9 = quantidadeEx9 * 5.00;
                        Console.WriteLine($"O valor total é de: {valorTotalEx9.ToString("F2")}");
                    }
                    else if (codigoEx9 == 4)
                    {
                        valorTotalEx9 = quantidadeEx9 * 2.00;
                        Console.WriteLine($"O valor total é de: {valorTotalEx9.ToString("F2")}");
                    }
                    else if (codigoEx9 == 5)
                    {
                        valorTotalEx9 = quantidadeEx9 * 1.50;
                        Console.WriteLine($"O valor total é de: {valorTotalEx9.ToString("F2")}");
                    }

                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("\n 10) Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos\r\nseguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em\r\nnenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.");
                    double valorEx10;
                    Console.Write("Informe o Valor: ");
                    valorEx10 = double.Parse(Console.ReadLine());
                    if(valorEx10 >= 0 && valorEx10 <= 25)
                    {
                        Console.WriteLine($"O valor {valorEx10.ToString("F2")} está no intervalo de [0 , 25]");
                    }
                    else if (valorEx10 > 25 && valorEx10 <= 50)
                    {
                        Console.WriteLine($"O valor {valorEx10.ToString("F2")} está no intervalo de [25 , 50]");
                    }
                    else if (valorEx10 > 50  && valorEx10 <= 75)
                    {
                        Console.WriteLine($"O valor {valorEx10.ToString("F2")} está no intervalo de [50 , 75]");
                    }
                    else if (valorEx10 > 75 && valorEx10 <= 100)
                    {
                        Console.WriteLine($"O valor {valorEx10.ToString("F2")} está no intervalo de [75 , 100]");
                    }
                    else
                    {
                        Console.WriteLine($"O valor {valorEx10.ToString("F2")} não está em nenhum intervalo");
                    }
                    break;
                    case 11:
                    Console.Clear();
                    Console.WriteLine("\n 11) Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas\r\n de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o\r\n ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).\r\n Se o ponto estiver na origem, escreva a mensagem “Origem”.\r\n Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a\r\n situação.");
                    Console.WriteLine("        |Y       ");
                    Console.WriteLine("        |       ");
                    Console.WriteLine("  Q2    |   Q1  ");
                    Console.WriteLine("        |       X");
                    Console.WriteLine("--------|--------");
                    Console.WriteLine("        |       ");
                    Console.WriteLine("  Q3    |  Q4   ");
                    Console.WriteLine("        |       ");
                    double eixoX, eixoY;
                    Console.Write("Informe o valor do eixo X: ");
                    eixoX = double.Parse(Console.ReadLine());
                    Console.Write("Informe o valor do eixo Y: ");
                    eixoY = double.Parse(Console.ReadLine());

                    if (eixoX == 0 && eixoY == 0)
                    {
                        Console.WriteLine($"O ponto ({eixoX},{eixoY}) está na Origem");
                    }
                    else if (eixoX == 0 && eixoY != 0 )
                    {
                        Console.WriteLine($"O ponto ({eixoX},{eixoY}) está no eixo X");

                    }
                    else if(eixoX != 0 && eixoY == 0)
                    {
                        Console.WriteLine($"O ponto ({eixoX},{eixoY}) está no eixo Y");
                    }
                    else if (eixoX > 0 && eixoY > 0)
                    {
                        Console.WriteLine($"O ponto ({eixoX},{eixoY}) está no quadrante Q1");
                    }
                    else if (eixoX < 0 && eixoY > 0)
                    {
                        Console.WriteLine($"O ponto ({eixoX},{eixoY}) está no quadrante Q2");
                    }
                    else if (eixoX < 0 && eixoY < 0 )
                    {
                        Console.WriteLine($"O ponto ({eixoX},{eixoY}) está no quadrante Q3");
                    }
                    else if (eixoX > 0 && eixoY < 0)
                    {
                        Console.WriteLine($"O ponto ({eixoX},{eixoY}) está no quadrante Q4");
                    }

                    break;
                case 12:
                    Console.Clear();
                    Console.WriteLine("\n 12) Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem\r\nque nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem\r\nqualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.\r\nLeia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e\r\nmostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.");
                    Console.WriteLine("            Renda            | Imposto de Renda");
                    Console.WriteLine(" de R$ 0,00 até R$ 2000,00   |     Isento");
                    Console.WriteLine("de R$ 2000,01 até R$ 3000,00 |       8%");
                    Console.WriteLine("de R$ 3000,01 até R$ 4500,00 |       18%");
                    Console.WriteLine("     acima de 4500,01        |       28% ");
                    Console.WriteLine("");
                    double salarioEx12, imposto, impostoFixo;
                    Console.Write("Informe o salário: ");
                    salarioEx12 = double.Parse(Console.ReadLine());
                    if(salarioEx12 < 2000)
                    {
                        Console.WriteLine("Isento");
                    }
                    else if (salarioEx12 > 2000 && salarioEx12 <= 3000)
                    {
                        salarioEx12 -= 2000;
                        imposto = salarioEx12 * 0.08;
                        Console.WriteLine($"O imposto de renda é de: {imposto.ToString("F2")}");
                    }
                    else if(salarioEx12 > 3000 && salarioEx12 <= 4500)
                    {
                        impostoFixo = 80.00;
                        salarioEx12 -= 3000;
                        imposto = (salarioEx12 * 0.18) + impostoFixo;
                        Console.WriteLine($"O imposto de renda é de: {imposto.ToString("F2")}");

                    }
                    else if (salarioEx12 > 4500)
                    {
                        impostoFixo = 350.00;
                        salarioEx12 -= 4500;
                        imposto = (salarioEx12 * 0.28) + impostoFixo;
                        Console.WriteLine($"O imposto de renda é de: {imposto.ToString("F2")}");

                    }
                    break;
            }
            
            
        }
    }
}
