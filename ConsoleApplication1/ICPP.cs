﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        //public double Calcula(Orcamento orcamento)
        //{
        //    if (orcamento.Valor >= 500)
        //    {
        //        return orcamento.Valor * 0.07;
        //    }
        //    return orcamento.Valor * 0.05;
        //}

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
           return orcamento.Valor >= 500;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
