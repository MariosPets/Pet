using System;
using System.Windows.Forms;

namespace MariosPet.Telas
{
    public partial class frmVacina : Form
    {
        public frmVacina()
        {
            InitializeComponent();
        }

        private void btmVoltar_Click(object sender, EventArgs e)
        {
            FrmFichaClinica fichaclinica = new FrmFichaClinica();
            fichaclinica.Show();
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmAnimal animal = new FrmAnimal();
            animal.ShowDialog();

        }
    }
}
