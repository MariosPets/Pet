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
    }
}
