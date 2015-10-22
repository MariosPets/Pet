using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Animal
    {
        #region Atributos

        public int id { get; set; }
        public string nome { get; set; }
        public int carteirinha { get; set; }
        public int idCliente { get; set; }
        public string racaPorte { get; set; }

        /// <summary>
        /// Sexo do animal:
        /// true - feminino
        /// false - masculino
        /// </summary>
        public bool sexo { get; set; }
        public string pelagemCor { get; set; }
        public DateTime nascimento { get; set; }
        public int idVeterinario { get; set; }

        #endregion
    }
}
