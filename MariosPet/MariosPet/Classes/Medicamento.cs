using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Medicamento
    {
        #region Atributos

        public int id { get; set; }
        public string descricao { get; set; }
        public int quantidade { get; set; }
        public int minimoEmEstoque { get; set; }
        public int maximoEmEstoque { get; set; }

        #endregion
    }
}
