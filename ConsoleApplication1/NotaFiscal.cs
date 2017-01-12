using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class NotaFiscal
    {
        public String RazaoSocial { get; set; }
        public String Cnpj { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Imposto { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public String Observacoes { get; set; }
   
        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataDeEmissao, double valorBruto, double imposto, IList<ItemDaNota> itens, string observacoes)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            DataDeEmissao = dataDeEmissao;
            ValorBruto = valorBruto;
            Imposto = imposto;
            Itens = itens;
            Observacoes = observacoes;
        }
    }
}

