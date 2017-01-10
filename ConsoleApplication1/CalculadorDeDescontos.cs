﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento) {
            //Chain of Responsibility
            Desconto d1 = new DescontoPorCincoItens();
            Desconto d2 = new DescontoPorMaisQuinhentosReais();
            Desconto d3 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            return d1.Desconta(orcamento);
        }
    }
}
