using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class EntradaProduto
    {
        public int idEntradaProduto { get; set; }
        public int idFornecedor { get; set; }
        public string data { get; set; }
        public string forma_pagamento { get; set; }
        public double desconto { get; set; }
        public double total { get; set; }


        public int teste { get; set; }
    }
}
