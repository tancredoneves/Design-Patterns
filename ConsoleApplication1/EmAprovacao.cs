using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class EmAprovacao : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor = orcamento.Valor - (orcamento.Valor - 0.5);
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento ainda em Aprovação");
        }

        public void Reprova(Orcamento orcamento)
        {
           orcamento.EstadoAtual = new Reprovado();
        }
    }
}
