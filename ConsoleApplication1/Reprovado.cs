using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento Reprovados");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento Reprovados");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento Reprovados");
        }
    }
}
