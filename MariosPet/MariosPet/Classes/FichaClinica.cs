using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class FichaClinica
    {
        #region Atributos

        public int id { get; set; }
        public int idAnimal { get; set; }
        public int idVeterinario { get; set; }
        public DateTime data { get; set; }
        public string historicoClinico { get; set; }
        public string queixaPrincipal { get; set; }
        public string suspeita { get; set; }
        public string prescricao { get; set; }
        public string sintomas { get; set; }
        public string examesComplementares { get; set; }
        public string observacao { get; set; }

        #endregion
    }
}
