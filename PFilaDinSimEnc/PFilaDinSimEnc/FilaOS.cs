using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFilaDinSimEnc
{
    class FilaOS
    {
        public OrdemServico Head { get; set; }
        public OrdemServico Tail { get; set; }

        public bool Vazia()
        {
            if ((Head == null) && (Tail == null))
                return true;
            return false;
        }

        public void Push(OrdemServico aux)
        {
            if (Vazia())
            {
                Head = aux;
                Tail = aux;
            }
            else
            {
                Tail.Proximo = aux; //Encadeamento da Nova OS (aux)
                Tail = aux; // Atualizo o Tail
            }
            Console.WriteLine("Elemento Inserido com sucesso!!!");
        }

        public void Print()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível Imprimir! Fila Vazia!");
                Console.ReadKey();
            }
            else
            {
                OrdemServico aux = Head;
                Console.WriteLine("\n>>>AS Ordens de Serviço são<<<\n");
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                } while (aux != null);
                Console.WriteLine("\n>>> FIM DA IMPRESSÃO <<<");
            }
        }

        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível Remover! Fila Vazia!");
                Console.ReadKey();
            }
            else
            {
                Head = Head.Proximo;
                Console.WriteLine("Elemento Removido com Sucesso!");
                if (Head == null)
                {
                    Tail = null;
                    Console.WriteLine("Fila agora está vazia!");
                    Console.ReadKey();
                }
            }
        }
    }
}
