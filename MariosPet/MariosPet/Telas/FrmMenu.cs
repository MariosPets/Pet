using MariosPet.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MariosPet.Telas
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.FrmCadastroCliente cadcli = new FrmCadastroCliente();
            cadcli.Show();
            Close();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAnimal animal = new FrmAnimal();
            animal.Show();
            Close();
        }

        private void cadastroToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmFornecedor fornecedor = new FrmFornecedor();
            fornecedor.Show();
            Close();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.FrmServico servico = new FrmServico();
            servico.Show();
            Close();            
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.FrmProduto produto = new FrmProduto();
            produto.Show();
            Close();
        }

        private void laboratóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.FrmLaboratorio laboratorio = new FrmLaboratorio();
            laboratorio.Show();
            Close();
        }

        private void fichaClínicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.FrmFichaClinica fichaClinica = new FrmFichaClinica();
            fichaClinica.Show();
            Close();
        }

        private void agendamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgenda agenda = new FrmAgenda();
            agenda.Show();
            Close();
        }

        private void anamneseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnamnese anamnese = new FrmAnamnese();
            anamnese.Show();
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmReceituario receituario = new FrmReceituario();
            receituario.Show();
            
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRemedio remedio = new FrmRemedio();
            remedio.Show();
            Close();
        }

        private void cadastroDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionario funcionario = new FrmFuncionario();
            funcionario.Show();
            Close();
        }

        private void toolStripMenuItem60_Click(object sender, EventArgs e)
        {
            FrmAgenda agenda = new FrmAgenda();
            agenda.ShowDialog();
            
        }

        private void consultasEPesquisasToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmPesquisas pesquisas = new FrmPesquisas();
            pesquisas.Show();
            Close();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OdbcConnection conexao = ConexaoPadrao.createConnection())
            {
                string sql = "BACKUP DATABASE MARIOS_PET TO DISK = 'D:\\MARIOS_PET_" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "_" + DateTime.Now.Second + ".Bak' WITH FORMAT, MEDIANAME = 'Z_SQLServerBackups', NAME = 'Full Backup of MARIOS_PET'";
                OdbcCommand command = new OdbcCommand(sql, conexao);

                conexao.Open();
                command.ExecuteNonQuery();
            }
        }

        private void carteirinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCateirinha carteirinha = new FrmCateirinha();
            carteirinha.Show();
            Close();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatóriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void prontuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void relatóriosToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmFornecedor fornecedor = new FrmFornecedor();
            fornecedor.ShowDialog();
            Close();
        }

        private void pagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aVistaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void parceladoToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            Close();
        }
    }
}
