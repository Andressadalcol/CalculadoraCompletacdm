using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCompletaCMD {


    internal class Program {

        enum Menu { Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, Raiz = 6, Sair = 7 }
        static void Main(string[] args) {

            bool escolheusair = false;

            while (!escolheusair) {
                Console.WriteLine("Seja bem vindo ao CALC, selecione uma das opções: ");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisao\n4-Multiplicacao\n5-Potencia\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao) {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Multiplicacao:
                        Mult();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheusair = true;
                        break;

                }

                Console.Clear();

            }


        }

        static void Soma() {


            Console.WriteLine("Soma de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Subtracao() {


            Console.WriteLine("Subtração de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Div() {


            Console.WriteLine("Divisão de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();


        }
        static void Mult() {


            Console.WriteLine("Multiplicação de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Pot() {


            Console.WriteLine("Potência de um número: ");
            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }
        static void Raiz() {


            Console.WriteLine("Raiz de um número: ");
            Console.WriteLine("Digite o número: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();


        }















        
    }
}       
       

