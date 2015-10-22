using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Produto
    {
        #region Atributos

        public int id { get; set; }
        public string descricao { get; set; }
        public string setor { get; set; }
        public int idFornecedor { get; set; }
        public string fabricante { get; set; }
        public DateTime vencimento { get; set; }
        public int quantidade { get; set; }
        public string unidade { get; set; }
        public double valorCusto { get; set; }
        public double valorVenda { get; set; }
        public double lucro { get; set; }
        public string tributacao { get; set; }
        public int minimoEmEstoque { get; set; }
        public int maximoEmEstoque { get; set; }
        public string codigoBarras { get; set; }

        #endregion
    }
}
