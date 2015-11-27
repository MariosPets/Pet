using MariosPet.Classes;
using MariosPet.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MariosPet.Telas
{
    public partial class FrmBuscaVacina : Form
    {
        Vacina classeVacina = new Vacina();
        Medicamento classeMed = new Medicamento();
        CrudVacina CrudVac = new CrudVacina();
        public FrmBuscaVacina()
        {
            InitializeComponent();
        }

        public void CopiarParaClasseVacina()
        {
            classeMed.descricao = txtPesquisaVacina.Text;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CopiarParaClasseVacina();

            dtgBuscaVacina.DataSource = CrudVac.consultaVacina("Select * from VACINA inner join MEDICAMENTO on MEDICAMENTO.ID_MEDICAMENTO = VACINA.ID_MEDICAMENTO where DESCRICAO like '%" + txtPesquisaVacina.Text + "%'"); 
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgBuscaVacina_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgBuscaVacina.Rows.Count > 0)
            {
                //Não sei se está certo
                classeVacina.id = Convert.ToInt32(dtgBuscaVacina.CurrentRow.Cells["ID_VACINA"].Value.ToString());
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmRemedio form = new FrmRemedio();
            Visible = false;
            form.ShowDialog();
            Visible = true;
        }
    }
}
