using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariosPet.Classes
{
    class Anamnese
    {
        #region Atributos

        public int id { get; set; }
        public bool vacinado { get; set; }
        public string doencas { get; set; }
        public string tratamentos { get; set; }
        public string sistemaDigestorio { get; set; }
        public string sistemaCardioRespiratorio { get; set; }
        public string sistemaGenitoUrinario { get; set; }
        public string sistemaNervosoLocomotor { get; set; }
        public string pelesAnexos { get; set; }
        public string manejo { get; set; }

        #endregion
    }
}
