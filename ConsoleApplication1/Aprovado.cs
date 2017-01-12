using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.02;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já Aprovado");
        }
    }
}
