using MariosPet.Classes;
using MariosPet.Crud;
using System;
using System.Data;
using System.Windows.Forms;

namespace MariosPet.Telas
{
    public partial class FrmFichaClinica : Form
    {
        Animal classeAni = new Animal();
        FichaClinica classeFichaCli = new FichaClinica();

        CrudAnimal CrudAni = new CrudAnimal();

        public FrmFichaClinica()
        {
            InitializeComponent();

            if (Estatica.id != 0)
            {
                CopiarParaFormulario();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtExames.Clear();
            txtHistoricoClinico.Clear();
            txtObservacao.Clear();
            txtPesquisaAnimal.Clear();
            txtPrescricao.Clear();
            txtQueixa.Clear();
            txtSintomas.Clear();
            txtSuspeita.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
           Close();
        }

        public void CopiarParaClasseFichaClinica()
        {
            //Animal
            classeAni.nome = txtPesquisaAnimal.Text;

            //Ficha Clinica
            classeFichaCli.historicoClinico = txtHistoricoClinico.Text;
            classeFichaCli.queixaPrincipal = txtQueixa.Text;
            classeFichaCli.suspeita = txtSuspeita.Text;
            classeFichaCli.prescricao = txtPrescricao.Text;
            classeFichaCli.sintomas = txtSintomas.Text;
            classeFichaCli.examesComplementares = txtExames.Text;
            classeFichaCli.observacao = txtObservacao.Text;
            classeFichaCli.data = DateTime.Now;
        }

        public void CopiarParaFormulario()
        {
            CrudFichaClinica CrudFichaCli = new CrudFichaClinica();

            string sql = "select * from ficha_clinica where id_ficha_clinica = " + Estatica.id.ToString();
            DataTable fichaclinica = CrudFichaCli.consultaFichaClinica(sql);

            //Dados Ficha Clinica
            classeFichaCli.id = Convert.ToInt32(fichaclinica.Rows[0][0].ToString());
            classeFichaCli.idAnimal = Convert.ToInt32(fichaclinica.Rows[0][1].ToString());
            classeFichaCli.idVeterinario = Convert.ToInt32(fichaclinica.Rows[0][2].ToString());
            classeFichaCli.data = Convert.ToDateTime(fichaclinica.Rows[0][3].ToString());
            txtQueixa.Text = fichaclinica.Rows[0][4].ToString();
            txtHistoricoClinico.Text = fichaclinica.Rows[0][5].ToString();
            txtSuspeita.Text = fichaclinica.Rows[0][6].ToString();
            txtSintomas.Text = fichaclinica.Rows[0][7].ToString();
            txtExames.Text = fichaclinica.Rows[0][8].ToString();
            txtPrescricao.Text = fichaclinica.Rows[0][9].ToString();
            txtObservacao.Text = fichaclinica.Rows[0][10].ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CopiarParaClasseFichaClinica();

            CrudFichaClinica CrudFichaCli = new CrudFichaClinica();

            if (Estatica.id != 0)
            {
                CrudFichaCli.alteraFichaClinica(classeFichaCli);

                Estatica.id = 0;
            }
            else
            {
                CrudFichaCli.inserirFichaClinica(classeFichaCli);

                classeFichaCli.id = Convert.ToInt32(CrudFichaCli.consultaFichaClinica("Select top 1 ID_FICHA_CLINICA from FICHA_CLINICA order by ID_FICHA_CLINICA desc").Rows[0][0].ToString());
            }
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmPesquisas form = new FrmPesquisas();
            Visible = false;
            form.ShowDialog();
            Visible = true;
        }

        private void roundButtonVacina_Click(object sender, EventArgs e)
        {
            frmVacina vacina = new frmVacina();
            Visible = false;
            vacina.ShowDialog();
            Visible = true;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            FrmVermifugo vermifugo = new FrmVermifugo();
            Visible = false;
            vermifugo.ShowDialog();
            Visible = true;
        }
    }
}
