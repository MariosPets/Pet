using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Exame
    {
        #region Atributos

        public int id { get; set; }
        public int idAnimal { get; set; }
        public int idVeterinario { get; set; }
        public int idLaboratorio { get; set; }
        public DateTime data { get; set; }
        public string exame { get; set; }

        #endregion
    }
}
