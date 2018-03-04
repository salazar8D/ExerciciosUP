using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projeto_1
{
    class Text
    {
        /// <summary>
        /// Este metodo mostra as opções de exercicios do Projeto1
        /// </summary>
        /// <returns></returns>
        public void Menu()
        {
            Console.WriteLine("Bem-Vindo ao Projeto 1 !!\n\n" +
                "1) Escreva um algoritmo que recebe um número e imprime na tela se ele é par ou ímpar.\n" +
                "2) Criar uma aplicação que receba dois números inteiros e imprima o intervalo entre esses dois números.\n" +
                "3) Crie um algoritmo capaz de jogar um dado (sortear números de 1 até 6). Em seguida lance o dado 1 milhão de vezes e imprima a porcentagem de vezes que cada número apareceu.\n" +
                "4) Escreva um algoritmo que recebe os valores necessários para o cálculo da fórmula de bhaskara e imprime, as suas raízes, caso seja possível calcular.\n" +
                "5) Escreva um método capaz de imprimir a sequência Fibonacci até o número 100.\n" +
                "6) Crie um algoritmo capaz de receber um vetor de 10 posições inteiras e organize o mesmo, sem a utilização de nenhuma função já existente em C#. (Olhar o Bubble Sort)\n\n" +
                "Digite a sua opção desejada ou digite qualquer outro numero para sair:");
        }
        /// <summary>
        /// Este metodo mostra o cabeçalho do Exercicio 1
        /// </summary>
        public void Exer1_1()
        {
            Console.Clear();
            Console.WriteLine("Exercicio 1\n\n" +
                "Favor entrar com o valor:");
        }
        /// <summary>
        /// Este metodo mostra o resultado par
        /// </summary>
        public void Exer1_2()
        {
            Console.WriteLine("\nO numero é par !");
            Thread.Sleep(3000);
            Console.Clear();
        }
        /// <summary>
        /// Este metodo mostra o resultado impar
        /// </summary>
        public void Exer1_3()
        {
            Console.WriteLine("\nO numero é impar !");
            Thread.Sleep(3000);
            Console.Clear();
        }

        /// <summary>
        /// Este metodo mostra a mensagem de erro para valores numéricos
        /// </summary>
        public void ErrorNumber()
        {
            Console.WriteLine("\nValor passado é inválido\n");
            Thread.Sleep(2000);
            Console.Clear();
        }

        /// <summary>
        /// Este metodo mostra a mensagem de saida do programa
        /// </summary>
        /// <returns></returns>
        public void Exit()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\t\t\tObrigado !");
            Thread.Sleep(3000);
            
        }

    }
}
