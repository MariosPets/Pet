using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Agendamento
    {
        #region Atributos

        public int id { get; set; }
        public int idCliente { get; set; }
        public int idFuncionario { get; set; }
        public int idServico { get; set; }
        public DateTime hora { get; set; }        
        public bool atendido { get; set; }

        #endregion
    }
}
