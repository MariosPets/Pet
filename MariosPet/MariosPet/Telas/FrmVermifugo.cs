using MariosPet.Classes;
using MariosPet.Crud;
using System;
using System.Windows.Forms;

namespace MariosPet.Telas
{
    public partial class FrmVermifugo : Form
    {
        CrudVermifugo crudVerm = new CrudVermifugo();

        public FrmVermifugo()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Estatica.buscaTipo = BuscaTipo.vermifugo;
            FrmBuscaVermifugo buscaVermifugo = new FrmBuscaVermifugo();
            buscaVermifugo.ShowDialog();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmVermifugo_Load(object sender, EventArgs e)
        {
            dtgVermifugo.DataSource = crudVerm.consultaVermifugo("select * from VERMIFUGO where ID_ANIMAL = " + Estatica.id);
        }

        private void dtgVermifugo_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
