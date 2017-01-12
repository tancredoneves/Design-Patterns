using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class NotaFiscalBuider
    {
        //Buider construtor
        //Fluent interface

        public String RazaoSocial { get; private set; }
        public String Cnpj { get; set; }
        public String Observacoes { get; private set; }
        public DateTime Data { get; private set; }
        private double valorTatal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();
        private IList<AcaoAposGeraNota> TodasAcoes = new List<AcaoAposGeraNota>();   

        public NotaFiscal Constroi()
        {
           NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, valorTatal, impostos, todosItens, Observacoes);
            foreach (AcaoAposGeraNota acao in TodasAcoes)
            {
                acao.Execulta(nf);
            }
        }

        public NotaFiscalBuider ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuider ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }
        public NotaFiscalBuider ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTatal += item.Valor;
            impostos += item.Valor + 0.05;
            return this;
        }
        public NotaFiscalBuider ComObservacoes(String observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }
        public NotaFiscalBuider NaDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }

    }
}
