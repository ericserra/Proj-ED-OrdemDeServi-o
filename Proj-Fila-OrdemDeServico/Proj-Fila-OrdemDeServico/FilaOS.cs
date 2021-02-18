using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Fila_OrdemDeServico
{
    class FilaOS
    {
        public OrdemServico Head { get; set; }
        public OrdemServico Tail { get; set; }
        
        public bool Vazia()
        {
            if (Head == null && Tail == null)
                return true;
            else
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
                Tail.Proximo = aux;
                Tail = aux;
            }
            Console.WriteLine("Ordem de Serviço Registrada com Sucesso!");
        }
        public void Print()
        {
            OrdemServico aux = Head;
            if (Vazia())
            {
                Console.WriteLine("Nenhuma Ordem de Serviço Registrada no momento");
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                } while (aux != null);
            }
        }
        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Não foi possível remover, pois ainda não há uma Ordem de Serviço registrada");
            }
            else
            {
                Head = Head.Proximo;
                Console.WriteLine("Ordem de Serviço Removida com Sucesso!");
                if (Head == null)
                {
                    Tail = null;
                    Console.WriteLine("Fila agora está vazia!");
                }
            }
        }
        public int Quantidade()
        {
            int cont = 0;
            if (Head != null)
            {
                OrdemServico aux = Head;
                do
                {
                    cont++;
                    aux = aux.Proximo;
                } while (aux != null);
            }
            return cont;
        }
        public void Busca(int id)
        {
            bool achou = false;
            if (Head == null)
                Console.WriteLine("Nenhuma ordem de serviço registrada");
            else
            {
                OrdemServico aux = Head;
                do
                {
                    if (id == aux.Numero)
                    {
                        achou = true;
                        Console.WriteLine("Ordem de Serviço localizada");
                        Console.WriteLine(aux.ToString());

                    }
                    aux = aux.Proximo;
                } while (aux != null);
                if (!achou)
                {
                    Console.WriteLine("Ordem de Serviço não localizada");
                }
                return;
            }
        }
    }
}
