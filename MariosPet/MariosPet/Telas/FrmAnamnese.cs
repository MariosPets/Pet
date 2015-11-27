
using MariosPet.Classes;
using MariosPet.Crud;
using System;
using System.Data;
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

            if (Estatica.id != 0)
            {
                CopiarParaFormulario();
            }
        }

        private void btmLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisaAnimal.Clear();
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
            classeAnam.data = DateTime.Now;
        }

        public void CopiarParaFormulario()
        {
            CrudAnamnese CrudAnam = new CrudAnamnese();

            string sql = "select * from anamnese id_anamnese = " + Estatica.id.ToString();
            DataTable anamnese = CrudAnam.consultaAnamnese(sql);

            //Anamnese            
            classeAnam.idAnimal = Convert.ToInt32(anamnese.Rows[0][0].ToString());
            classeAnam.idVeterinario = Convert.ToInt32(anamnese.Rows[0][1].ToString());
            radioButtonSim.Text = anamnese.Rows[0][2].ToString();
            radioButtonNao.Text = anamnese.Rows[0][2].ToString();
            richTextBoxDoenca.Text = anamnese.Rows[0][3].ToString();
            richTextBoxTratamento.Text = anamnese.Rows[0][4].ToString();
            richTextBoxDigestorio.Text = anamnese.Rows[0][5].ToString();
            richTextBoxCardioRespiratorio.Text = anamnese.Rows[0][6].ToString();
            richTextBoxGenitoUrinario.Text = anamnese.Rows[0][7].ToString();
            richTextBoxNervosoLocomotor.Text = anamnese.Rows[0][8].ToString();
            richTextBoxPelesAnexos.Text = anamnese.Rows[0][9].ToString();
            richTextBoxManejo.Text = anamnese.Rows[0][10].ToString();
            classeAnam.data = Convert.ToDateTime(anamnese.Rows[0][11].ToString());
            classeAnam.id = Convert.ToInt32(anamnese.Rows[0][12].ToString());
        }

        private void btmSalvar_Click(object sender, EventArgs e)
        {
            CopiarParaClasseAnamnese();

            CrudAnamnese CrudAnam = new CrudAnamnese();

            if (Estatica.id != 0)
            {
                CrudAnam.alteraAnamnese(classeAnam);
                Estatica.id = 0;
            }
            else
            {
                CrudAnam.inserirAnamnese(classeAnam);
                classeAnam.id = Convert.ToInt32(CrudAnam.consultaAnamnese("Select top 1 ID_ANAMNESE from ANAMNESE order by ID_ANAMNESE desc").Rows[0][0].ToString());
            }           
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
                radioButtonSim.Checked = false;
            }
            else
            {
                radioButtonSim.Checked = true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmPesquisas form = new FrmPesquisas();
            Visible = false;
            form.ShowDialog();
            Visible = true;
        }
    }
}
