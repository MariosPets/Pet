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
    public partial class FrmFichaClinica : Form
    {
        Animal classeAni = new Animal();
        FichaClinica classeFichaCli = new FichaClinica();

        CrudAnimal CrudAni = new CrudAnimal();

        public FrmFichaClinica()
        {
            InitializeComponent();
        }

        private void txtHistoricoClinico_TextChanged(object sender, EventArgs e)
        {

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
            dtgAnimal.ClearSelection();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Telas.FrmMenu menu = new FrmMenu();
            menu.Show();
            Close();
        }

        private void btmNovo_Click(object sender, EventArgs e)
        {
            Telas.FrmAnimal animal = new FrmAnimal();
            animal.Show();
        }

        private void btnVermifugoVacina_Click(object sender, EventArgs e)
        {
            Telas.frmVacina vacina = new frmVacina();
            vacina.ShowDialog();
        }

        private void txtQueixa_TextChanged(object sender, EventArgs e)
        {

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
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CopiarParaClasseFichaClinica();
            CrudFichaClinica CrudFichaCli = new CrudFichaClinica();
            
            CrudFichaCli.inserirFichaClinica(classeFichaCli);
            CrudAni.inserirAnimal(classeAni);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CopiarParaClasseFichaClinica();

            dtgAnimal.DataSource = CrudAni.consultaAnimal("Select * from ANIMAL where NOME like '%" + txtPesquisaAnimal.Text + "%'");
        }

        private void roundButtonVacina_Click(object sender, EventArgs e)
        {
            frmVacina vacina = new frmVacina();
            vacina.ShowDialog();

        }
    }
}
