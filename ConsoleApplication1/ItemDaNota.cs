using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ItemDaNota
    {
        public ItemDaNota(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public String Nome { get; set; }
        public double Valor { get; set; }

       
    }
}
