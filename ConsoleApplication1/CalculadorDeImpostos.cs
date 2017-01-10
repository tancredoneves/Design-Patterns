using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, String imposto)
        {

            if ("ICMS".Equals(imposto))//evita o nullexception na string se imposto vir vazio
            {
                double icms = orcamento.Valor * 0.1;
            }
            if ("ISS".Equals(imposto))
            {
                double iss = new ISS().CalculaISS(orcamento);
            }

        }

    }
}
