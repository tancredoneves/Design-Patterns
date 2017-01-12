using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento Finalizado");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("rOçamento finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já finalizado");
        }
    }
}
