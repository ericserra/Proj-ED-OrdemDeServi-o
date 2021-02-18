using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFilaDinSimEnc
{
    class OrdemServico
    {
        public int Numero{ get; set; }
        public string Tipo { get; set; }
        public string  Descricao { get; set; }
        public DateTime Data_Criacao { get; set; }
        public int Prazo { get; set; }
        public OrdemServico Proximo { get; set; }

        public override string ToString()
        {
            return "\n>>>DADOS DA O.S.<<<\nNumero da O.S.:"+Numero+"\nTipo:"+Tipo+"\nDescrição:"+Descricao+"\nData da Pedido:"+Data_Criacao+"\nPraza em dias:"+Prazo;
        }

    }
}
