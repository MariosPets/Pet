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
    public partial class FrmAnamnese : Form
    {
        Anamnese classeAnam = new Anamnese();

        CrudAnimal CrudAni = new CrudAnimal();
        public FrmAnamnese()
        {
            InitializeComponent();
        }

        private void btmLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisaAnimal.Clear();
            dtgAnimal.ClearSelection();
            richTextBoxDoenca.Clear();
            richTextBoxCardioRespiratorio.Clear();
            richTextBoxDigestorio.Clear();
            richTextBoxGenitoUrinario.Clear();
            richTextBoxManejo.Clear();
            richTextBoxNervosoLocomotor.Clear();
            richTextBoxPelesAnexos.Clear();
            richTextBoxTratamento.Clear();
        }

        private void btmVoltar_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmAnimal animal = new FrmAnimal();
            animal.Show();
            Close();
        }

        public void CopiarParaClasseAnamnese()
        {
            //Anamnese
            classeAnam.vacinado = radioButtonNao.Checked;
            classeAnam.doencas = richTextBoxDoenca.Text;
            classeAnam.tratamentos = richTextBoxTratamento.Text;
            classeAnam.sistemaDigestorio = richTextBoxGenitoUrinario.Text;
            classeAnam.sistemaCardioRespiratorio = richTextBoxCardioRespiratorio.Text;
            classeAnam.sistemaGenitoUrinario = richTextBoxDigestorio.Text;
            classeAnam.sistemaNervosoLocomotor = richTextBoxNervosoLocomotor.Text;
            classeAnam.pelesAnexos = richTextBoxPelesAnexos.Text;
            classeAnam.manejo = richTextBoxManejo.Text;
        }

        private void btmSalvar_Click(object sender, EventArgs e)
        {
            CopiarParaClasseAnamnese();

            CrudAnamnese CrudAnam = new CrudAnamnese();

            CrudAnam.inserirAnamnese(classeAnam);
        }

        private void radioButtonSim_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSim.Checked == true)
            {
                radioButtonNao.Checked = false;
            }
            else
            {
                radioButtonNao.Checked = true;
            }
        }

        private void radioButtonNao_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNao.Checked == true)
            {
                radioButtonNao.Checked = false;
            }
            else
            {
                radioButtonNao.Checked = true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CopiarParaClasseAnamnese();

            dtgAnimal.DataSource = CrudAni.consultaAnimal("Select * from ANIMAL where NOME like '%" + txtPesquisaAnimal.Text + "%'");
        }
    }
}
