using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFilaDinSimEnc
{
    class Program
    {
        static void Main(string[] args)
        {
            FilaOS minha_fila = new FilaOS
            {
                Head = null,
                Tail = null
            };

            OrdemServico os = new OrdemServico
            {
                Numero = 123,
                Tipo = "Usinagem",
                Descricao = "Fazer 100 unidades pedaleira de moto",
                //Data_Criacao = DateTime.Parse("20/01/2020"),
                Data_Criacao = DateTime.Now,
                Prazo = 10,
                Proximo = null
            };

            minha_fila.Print();

          /*  minha_fila.Pop();

            minha_fila.Push(os);

            os = new OrdemServico
            {
                Numero = 456,
                Tipo = "Pintura",
                Descricao = "pintar 20 quadros de BMW1200",
                //Data_Criacao = DateTime.Parse("20/01/2020"),
                Data_Criacao = DateTime.Now,
                Prazo = 15,
                Proximo = null
            };
            minha_fila.Push(os);

            os = new OrdemServico
            {
                Numero = 888,
                Tipo = "Montar Moto",
                Descricao = "Montar 10 unidades de BIZ 100",
                //Data_Criacao = DateTime.Parse("20/01/2020"),
                Data_Criacao = DateTime.Now,
                Prazo = 7,
                Proximo = null
            };
            minha_fila.Push(os);

            minha_fila.Print();

            minha_fila.Pop();
            minha_fila.Print();

            minha_fila.Pop();
            minha_fila.Pop();

            minha_fila.Pop();

            //Console.WriteLine(os.ToString());
            */
            Console.ReadKey();


        }
    }
}
