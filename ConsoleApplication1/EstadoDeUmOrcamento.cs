using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface EstadoDeUmOrcamento
    {
        //State
        void AplicaDescontoExtra(Orcamento orcamento);
        void Aprova(Orcamento orcamento);
        void Reprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);
    }
}
