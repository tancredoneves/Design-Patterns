using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Decorator
            // Imposto iss = new ISS(new ICMS(new ICPP()));

            //Method chaining
            //NotaFiscalBuider criador = new NotaFiscalBuider();
            //criador
            //    .ParaEmpresa("curso")
            //    .ComCnpj("15151")
            //    .ComItem(new ItemDaNota("item 1", 200))
            //    .NaDataAtual()
            //    .ComObservacoes("obs");
            //NotaFiscal nf = criador.Controi();
            //Console.WriteLine(nf.ValorBruto);

        }
    }
}
