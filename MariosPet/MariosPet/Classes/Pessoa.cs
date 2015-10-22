using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Pessoa
    {
        #region Atributos

        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string nascimento { get; set; }
        public int idEndereco { get; set; }
        public string email { get; set; }
        public string telefone1 { get; set; }
        public string telefone2 { get; set; }
        public string telefone3 { get; set; }

        #endregion
    }
}
