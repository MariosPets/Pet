using System;
using System.Windows.Forms;

namespace MariosPet.Telas
{
    public partial class FrmVermifugo : Form
    {
        public FrmVermifugo()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmBuscaVermifugo buscaVermifugo = new FrmBuscaVermifugo();
            buscaVermifugo.ShowDialog();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
