using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FDevs.CSharp.ExerciciosDesafio
{
    class Exercicios
    {
        static void Main(string[] args)
        {
            Console.Write("EXERCÍCIOS DO DESAFIO C#: " + "\n");
            Console.Write("-----------------------------" + "\n");
            Console.Write("- - - EXERCÍCIO 1 - - - " + "\n");
            Console.Write("Soma dos números de 1 a 10 " + "\n");
            Console.ReadKey();
            int soma = 0;
            for (int i = 1; i <= 10; i++)
            {
                soma = soma + i;
            }
            Console.Write("O resultado é: "+ soma + "\n");
            Console.ReadKey();
            Console.Write("-----------------------------" + "\n");
            Console.Write("- - - EXERCÍCIO 2 - - - " + "\n");
            Console.Write("Calculadora de IMC " + "\n");
            Console.ReadKey();
            //-----------------------------------------------------

            Console.Write("Insira seu peso em kg (Ex: 70,0): ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira sua altura em metros (Ex: 1,75): ");
            double altura = Convert.ToDouble(Console.ReadLine());
            double imc = peso / (altura * altura);
            imc = Math.Round(imc, 2);

            if (imc < 18.5)
            {
                Console.Write("------------------------------------------------------------------------" + "\n");
                Console.Write("Seu IMC é: " + imc + "\n");
                Console.Write("A faixa de classificação do seu IMC é: Magreza" + "\n");
                Console.Write("------------------------------------------------------------------------");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.Write("------------------------------------------------------------------------" + "\n");
                Console.Write("Seu IMC é: " + imc + "\n");
                Console.Write("A faixa de classificação do seu IMC é: Saudável" + "\n");
                Console.Write("------------------------------------------------------------------------");
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                Console.Write("------------------------------------------------------------------------" + "\n");
                Console.Write("Seu IMC é: " + imc + "\n");
                Console.Write("A faixa de classificação do seu IMC é: Sobrepeso" + "\n");
                Console.Write("------------------------------------------------------------------------");
            }
            else if (imc >= 30.0 && imc <= 34.9)
            {
                Console.Write("------------------------------------------------------------------------" + "\n");
                Console.Write("Seu IMC é: " + imc + "\n");
                Console.Write("A faixa de classificação do seu IMC é: Obesidade Grau 1" + "\n");
                Console.Write("------------------------------------------------------------------------");
            }
            else if (imc >= 35.0 && imc <= 39.9)
            {
                Console.Write("------------------------------------------------------------------------" + "\n");
                Console.Write("Seu IMC é: " + imc + "\n");
                Console.Write("A faixa de classificação do seu IMC é: Obesidade Grau 2 (Severa)" + "\n");
                Console.Write("------------------------------------------------------------------------");
            }
            else
            {
                Console.Write("------------------------------------------------------------------------" + "\n");
                Console.Write("Seu IMC é: " + imc + "\n");
                Console.Write("A faixa de classificação do seu IMC é: Obesidade Grau 3 (Morbida)" + "\n");
                Console.Write("------------------------------------------------------------------------");
            }
            Console.ReadKey();
            Console.Write("" + "\n");
            Console.Write("-----------------------------" + "\n");
            Console.Write("- - - EXERCÍCIO 3 - - - " + "\n");
            Console.Write("Calculadora Simples " + "\n");
            Console.ReadKey();

            //-----------------------------------------------------
            //-----------------------------------------------------
            Console.Write("Insira o 1º número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira o 2º número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("-----------------------------" + "\n");
            Console.Write("OPERADORES: " + "\n");
            Console.Write("Soma: (+)" + "\n");
            Console.Write("Subtração: (-)" + "\n");
            Console.Write("Multiplicação: (*)" + "\n");
            Console.Write("Divisão: (/)" + "\n");
            Console.Write("-----------------------------" + "\n");
            Console.Write("Escolha o operador desejado: ");
            string operador = Console.ReadLine();
            switch (operador)
            {
                case "+":
                    Console.Write(n1 + " + " + n2 + " = " + (n1 + n2));
                    break;
                case "-":
                    Console.Write(n1 + " - " + n2 + " = " + (n1 - n2));
                    break;
                case "*":
                    Console.Write(n1 + " * " + n2 + " = " + (n1 * n2));
                    break;
                case "/":
                    Console.Write(n1 + " / " + n2 + " = " + (n1 / n2));
                    break;
                default:
                    Console.Write("Operador inválido!");
                    break;
            }
        }
    }
}