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
            }
        }
    }
}
