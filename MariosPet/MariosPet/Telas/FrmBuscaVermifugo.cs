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
    public partial class FrmBuscaVermifugo : Form
    {
        Medicamento classeMed = new Medicamento();
        CrudVermifugo CrudVerm = new CrudVermifugo();

        public FrmBuscaVermifugo()
        {
            InitializeComponent();
        }

        public void CopiarParaClasseVermifugo()
        {
            classeMed.descricao = txtVermifugo.Text;
        }

        private void btmConsultar_Click(object sender, EventArgs e)
        {
            CopiarParaClasseVermifugo();

            dtgVermifugo.DataSource = CrudVerm.consultaVermifugo("Select * from VERMIFUGO inner join MEDICAMENTO on MEDICAMENTO.ID_MEDICAMENTO = VERMIFUGO.ID_MEDICAMENTO where DESCRICAO like '%" + txtVermifugo.Text + "%'");
        }

        private void btmVoltar_Click(object sender, EventArgs e)
        {
            FrmVermifugo vermifugo = new FrmVermifugo();
            vermifugo.ShowDialog();
            Close();
        }
    }
}
