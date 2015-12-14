using MariosPet.Classes;
using MariosPet.Crud;
using System;
using System.Windows.Forms;

namespace MariosPet.Telas
{
    public partial class frmVacina : Form
    {
        CrudVacina crudVaci = new CrudVacina(); 
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
            Estatica.buscaTipo = BuscaTipo.vacina;
            
            FrmBuscaVacina buscaVacina = new FrmBuscaVacina();
            buscaVacina.ShowDialog();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmVacina_Load(object sender, EventArgs e)
        {
            dtgVacina.DataSource = crudVaci.consultaVacina("select * from VACINA where ID_ANIMAL = " + Estatica.id);
        }
    }
}
