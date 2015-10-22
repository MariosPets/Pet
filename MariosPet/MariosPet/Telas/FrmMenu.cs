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
            animal.ShowDialog();
            
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
            servico.ShowDialog();
            Close();            
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.FrmProduto produto = new FrmProduto();
            produto.ShowDialog();
            Close();
        }

        private void laboratóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.FrmLaboratorio laboratorio = new FrmLaboratorio();
            laboratorio.ShowDialog();
            Close();
        }

        private void fichaClínicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.FrmFichaClinica fichaClinica = new FrmFichaClinica();
            fichaClinica.ShowDialog();
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
            anamnese.ShowDialog();
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmReceituario receituario = new FrmReceituario();
            receituario.ShowDialog();
            Close();
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRemedio remedio = new FrmRemedio();
            remedio.ShowDialog();
            Close();
        }

        private void cadastroDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionario funcionario = new FrmFuncionario();
            funcionario.ShowDialog();
            Close();
        }
    }
}
