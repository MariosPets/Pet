using MariosPet.Classes;
using System;
using System.Data.Odbc;
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
            Estatica.tipoAcao = TipoAcao.inserir;
            
            FrmCadastroCliente cadcli = new FrmCadastroCliente();
            Visible = false;
            cadcli.ShowDialog();
            Visible = true;
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Estatica.tipoAcao = TipoAcao.inserir;
            FrmAnimal animal = new FrmAnimal();
            Visible = false;
            animal.ShowDialog();
            Visible = true;
        }

        private void cadastroToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Estatica.tipoAcao = TipoAcao.inserir;
            FrmFornecedor fornecedor = new FrmFornecedor();
            Visible = false;
            fornecedor.ShowDialog();
            Visible = true;
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estatica.tipoAcao = TipoAcao.inserir;
            FrmServico servico = new FrmServico();
            Visible = false;
            servico.ShowDialog();
            Visible = true;
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estatica.tipoAcao = TipoAcao.inserir;
            FrmProduto produto = new FrmProduto();
            Visible = false;
            produto.ShowDialog();
            Visible = true;
        }

        private void laboratóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estatica.tipoAcao = TipoAcao.inserir;
            FrmLaboratorio laboratorio = new FrmLaboratorio();
            Visible = false;
            laboratorio.ShowDialog();
            Visible = true;
        }

        private void fichaClínicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estatica.tipoAcao = TipoAcao.inserir;
            FrmFichaClinica fichaClinica = new FrmFichaClinica();
            Visible = false;
            fichaClinica.ShowDialog();
            Visible = true;
        }

        private void agendamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgenda agenda = new FrmAgenda();
            Visible = false;
            agenda.ShowDialog();
            Visible = true;
        }

        private void anamneseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estatica.tipoAcao = TipoAcao.inserir;
            FrmAnamnese anamnese = new FrmAnamnese();
            Visible = false;
            anamnese.ShowDialog();
            Visible = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmReceituario receituario = new FrmReceituario();
            Visible = false;
            receituario.ShowDialog();
            Visible = true;
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estatica.tipoAcao = TipoAcao.inserir;
            FrmRemedio remedio = new FrmRemedio();
            Visible = false;
            remedio.ShowDialog();
            Visible = true;
        }

        private void cadastroDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estatica.tipoAcao = TipoAcao.inserir;
            FrmFuncionario funcionario = new FrmFuncionario();
            Visible = false;
            funcionario.ShowDialog();
            Visible = true;
        }

        private void toolStripMenuItem60_Click(object sender, EventArgs e)
        {
            FrmAgenda agenda = new FrmAgenda();
            Visible = false;
            agenda.ShowDialog();
            Visible = true;
        }

        private void consultasEPesquisasToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Estatica.buscaTipo = BuscaTipo.geral;
            FrmPesquisas pesquisas = new FrmPesquisas();
            Visible = false;
            pesquisas.ShowDialog();
            Visible = true;
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
            Visible = false;
            carteirinha.ShowDialog();
            Visible = true;
        }
        
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Estatica.tipoAcao = TipoAcao.inserir;
            FrmFornecedor fornecedor = new FrmFornecedor();
            Visible = false;
            fornecedor.ShowDialog();
            Visible = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            Visible = false;
            login.ShowDialog();
            Visible = true;
        }
    }
}
