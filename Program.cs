using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frutas
{
    class Program
    {
        
        enum menu { Comprar = 1, Listar, Sair}
        enum frutas { Laranja = 1, Banana, Melancia, Uva}

        static void Main(string[] args)
        {
            int quantidade, escolhaFruta;

            Console.WriteLine("HORTIFRUTI\n");
            Console.WriteLine("Selecione uma das opcoes abaixo: ");
            Console.WriteLine("1-Comprar Frutas\n2-Listar\n3-Sair\n");
            int escolha = int.Parse(Console.ReadLine());
                
            menu Opcao = (menu)escolha;

            

            switch (Opcao)
            {
                case menu.Comprar:
                    Console.WriteLine("\nSelecione a fruta desejada abaixo: ");
                    Console.WriteLine("1-Laranja\n2-Banana\n3-Melancia\n4-Uva\n");
                    escolhaFruta = int.Parse(Console.ReadLine());

                    if (escolhaFruta == 1)
                    {            

                        Console.WriteLine("Informe a quantidade: ");
                        quantidade = int.Parse(Console.ReadLine());

                        Console.WriteLine($"\nFruta escolhida: Laranja\nQuantidade: {quantidade}");
                        Console.WriteLine($"Valor total: {quantidade*4},00R$");
                        Console.WriteLine("Volte Sempre!!!");
                    }

                    else if (escolhaFruta == 2)
                    {

                        Console.WriteLine("Informe a quantidade: ");
                        quantidade = int.Parse(Console.ReadLine());

                        Console.WriteLine($"\nFruta escolhida: Banana\nQuantidade: {quantidade}");
                        Console.WriteLine($"Valor total: {quantidade * 2},00R$");
                        Console.WriteLine("Volte Sempre!");
                    }

                    else if (escolhaFruta == 3)
                    {

                        Console.WriteLine("Informe a quantidade: ");
                        quantidade = int.Parse(Console.ReadLine());

                        Console.WriteLine($"\nFruta escolhida: Melancia\nQuantidade: {quantidade}");
                        Console.WriteLine($"Valor total: {quantidade * 7},00R$");
                        Console.WriteLine("Volte Sempre!");
                    }

                    else if (escolhaFruta == 4)
                    {

                        Console.WriteLine("Informe a quantidade: ");
                        quantidade = int.Parse(Console.ReadLine());

                        Console.WriteLine($"\nFruta escolhida: Uva\nQuantidade: {quantidade}");
                        Console.WriteLine($"Valor total: {quantidade * 3},00R$");
                        Console.WriteLine("Volte Sempre!");
                    }

                    else
                    {
                        Console.WriteLine("Escolha uma fruta no estoque.");
                    }

                    break;
                
                case menu.Listar:
                    Console.WriteLine("\nEstoque de frutas disponiveis: \n");
                    Console.WriteLine("Laranja\nBanana\nMelancia\nUva");

                    Console.WriteLine("\nDeseja voltar para o Menu principal?\n");
                    Console.WriteLine("Digite 'sim' para voltar ao menu.\n");
                    string voltarMenu = Console.ReadLine();
                    
                    if(voltarMenu == "sim")
                    {
                        BackMenu();
                    }
                    else
                    {
                        break;
                    }
                    break;
                
                case menu.Sair:
                    Console.WriteLine("Ate breve!");
                    break;

                default:
                    Console.WriteLine("Insira uma opcao valida");
                    break;
            }


                    Console.ReadLine();
        }
        
        static public void BackMenu()
        {

            int quantidade, escolhaFruta;

            Console.WriteLine("\nHORTIFRUTI\n");
            Console.WriteLine("Selecione uma das opcoes abaixo: ");
            Console.WriteLine("1-Comprar Frutas\n2-Listar\n3-Sair\n");
            int escolha = int.Parse(Console.ReadLine());

            menu Opcao = (menu)escolha;



            switch (Opcao)
            {
                case menu.Comprar:
                    Console.WriteLine("\nSelecione a fruta desejada abaixo: ");
                    Console.WriteLine("1-Laranja\n2-Banana\n3-Melancia\n4-Uva\n");
                    escolhaFruta = int.Parse(Console.ReadLine());

                    if (escolhaFruta == 1)
                    {

                        Console.WriteLine("Informe a quantidade: ");
                        quantidade = int.Parse(Console.ReadLine());

                        Console.WriteLine($"\nFruta escolhida: Laranja\nQuantidade: {quantidade}");
                        Console.WriteLine($"Valor total: {quantidade * 4},00R$");
                        Console.WriteLine("Volte Sempre!!!");
                    }

                    else if (escolhaFruta == 2)
                    {

                        Console.WriteLine("Informe a quantidade: ");
                        quantidade = int.Parse(Console.ReadLine());

                        Console.WriteLine($"\nFruta escolhida: Banana\nQuantidade: {quantidade}");
                        Console.WriteLine($"Valor total: {quantidade * 2},00R$");
                        Console.WriteLine("Volte Sempre!");
                    }

                    else if (escolhaFruta == 3)
                    {

                        Console.WriteLine("Informe a quantidade: ");
                        quantidade = int.Parse(Console.ReadLine());

                        Console.WriteLine($"\nFruta escolhida: Melancia\nQuantidade: {quantidade}");
                        Console.WriteLine($"Valor total: {quantidade * 7},00R$");
                        Console.WriteLine("Volte Sempre!");
                    }

                    else if (escolhaFruta == 4)
                    {

                        Console.WriteLine("Informe a quantidade: ");
                        quantidade = int.Parse(Console.ReadLine());

                        Console.WriteLine($"\nFruta escolhida: Uva\nQuantidade: {quantidade}");
                        Console.WriteLine($"Valor total: {quantidade * 3},00R$");
                        Console.WriteLine("Volte Sempre!");
                    }

                    else
                    {
                        Console.WriteLine("Escolha uma fruta no estoque.");
                    }

                    break;

                case menu.Listar:
                    Console.WriteLine("\nEstoque de frutas disponiveis: \n");
                    Console.WriteLine("Laranja\nBanana\nMelancia\nUva");
                    break;

                case menu.Sair:
                    Console.WriteLine("Ate breve!");
                    break;

                default:
                    Console.WriteLine("Insira uma opcao valida");
                    break;
            }


            Console.ReadLine();
        }
    
        
    
    
    
    }
}
