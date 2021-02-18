using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Fila_OrdemDeServico
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuinterno = 0;
            int menu = 0;
            FilaOS minha_fila = new FilaOS
            {
                Head = null,
                Tail = null
            };
            OrdemServico os;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("            Bem vindo\nMenu do Portal de Requerimento de Serviços");
                Console.ResetColor();
                Console.WriteLine("\n1 - Registrar Ordem de Serviço");
                Console.WriteLine("\n2 - Remover Ordem de Serviço");
                Console.WriteLine("\n3 - Imprimir Ordens de Serviço Registradas");
                Console.WriteLine("\n4 - Quantidade de Ordens de Serviços Pendentes");
                Console.WriteLine("\n5 - Buscar Ordem de Serviço por ID");
                Console.WriteLine("\n0 - Sair do Programa");
                Console.Write("\n\nEscolha uma opção: ");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        os = LerOS();
                        minha_fila.Push(os);
                        string voltar1 = "";
                        Console.Write("\nDeseja voltar para o menu inicial?(S/N): ");
                        voltar1 = Console.ReadLine();
                        if (voltar1 == "S")
                        {
                            Console.Clear();
                            menu = 0;
                        }
                        else
                        {
                            menu = 1;
                            Console.Write("\nAperte enter para sair...");
                        }
                        break;
                    case 2:
                        minha_fila.Pop();
                        voltar1 = null;
                        Console.Write("\nDeseja voltar para o menu inicial?(S/N): ");
                        voltar1 = Console.ReadLine();
                        if (voltar1 == "S")
                        {
                            Console.Clear();
                            menu = 0;
                        }
                        else
                        {
                            menu = 1;
                            Console.Write("\nAperte enter para sair...");
                        }
                        break;
                    case 3:
                        minha_fila.Print();
                        Console.Write("\nDeseja voltar para o menu inicial?(S/N): ");
                        voltar1 = Console.ReadLine();
                        if (voltar1 == "S")
                        {
                            Console.Clear();
                            menu = 0;
                        }
                        else
                        {
                            menu = 1;
                            Console.Write("\nAperte enter para sair...");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Quantidade de ordens de serviço pendentes: " + minha_fila.Quantidade());
                        Console.Write("\nDeseja voltar para o menu inicial?(S/N): ");
                        voltar1 = Console.ReadLine();
                        if (voltar1 == "S")
                        {
                            Console.Clear();
                            menu = 0;
                        }
                        else
                        {
                            menu = 1;
                            Console.Write("\nAperte enter para sair...");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Informe um ID de Ordem de Serviço para busca: ");
                        int id = int.Parse(Console.ReadLine());
                        minha_fila.Busca(id);
                        Console.Write("\nDeseja voltar para o menu inicial?(S/N): ");
                        voltar1 = Console.ReadLine();
                        if (voltar1 == "S")
                        {
                            Console.Clear();
                            menu = 0;
                        }
                        else
                        {
                            menu = 1;
                            Console.Write("\nAperte enter para sair...");
                        }
                        break;
                        
                }
            } while (menu == 0);
            Console.ReadKey();
        }
        static public OrdemServico LerOS()
        {
            int numero, prazo;
            string descricao, tipo;
            do
            {
                Console.Write("Informe o ID da Ordem de Serviço: ");
                numero = int.Parse(Console.ReadLine());
            } while (numero <= 0);
            do
            {
                Console.Write("Informe o tipo de serviço: ");
                tipo = Console.ReadLine();
            } while (tipo == "");
            do
            {
                Console.Write("Informe a descrição do serviço: ");
                descricao = Console.ReadLine();
            } while (descricao == "");
            do
            {
                Console.Write("Informe o prazo de entrega da ordem(obs: o prazo minimo é de até 1 dia): ");
                prazo = int.Parse(Console.ReadLine());
            } while (prazo <= 0);
            OrdemServico os1 = new OrdemServico
            {
                Numero = numero,
                Tipo = tipo,
                Descricao = descricao,
                Prazo = prazo,
                Data_Criacao = DateTime.Now
            };
            return os1;
        }
    }
}
