using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Fornecedor: PessoaJuridica
    {
        #region Atributos

        public string ramoAtividade { get; set; }
        public string nomeContato { get; set; }

        #endregion
    }
}
