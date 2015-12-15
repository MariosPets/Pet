using MariosPet.Classes;
using MariosPet.Crud;
using System;
using System.Windows.Forms;

namespace MariosPet.Telas
{
    public partial class FrmPesquisas : Form
    {
        CrudAnimal CrudAni = new CrudAnimal();
        CrudCliente CrudCli = new CrudCliente();
        CrudFichaClinica CrudFichaCli = new CrudFichaClinica();
        CrudFornecedor CrudForn = new CrudFornecedor();
        CrudFuncionario CrudFunc = new CrudFuncionario();
        CrudLaboratorio CrudLab = new CrudLaboratorio();
        CrudMedicamento CrudMed = new CrudMedicamento();
        CrudProduto CrudProd = new CrudProduto();
        CrudServico CrudServ = new CrudServico();
        CrudVeterinario CrudVet = new CrudVeterinario();

        string tabela = "";
        string condicao = "";

        public FrmPesquisas()
        {
            InitializeComponent();
            
            switch (Estatica.buscaTipo)
            {
                case BuscaTipo.cliente:

                    comboBoxTipo.Text = "Clientes";
                    comboBoxTipo.Enabled = false;

                    break;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
      
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridViewPesquisas.DataSource = CrudCli.consultaCliente(tabela + " where nome like('%" + txtPesquisa.Text + "%')");

        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPesqPor.Items.Clear();
            
            switch (comboBoxTipo.SelectedIndex) { 
                case 0:
                    tabela = "select * from cliente inner join pessoa on pessoa.id_pessoa = cliente.id_pessoa ";
                    
                    break;
                case 1:
                    tabela = "select * from animal ";

                    break;
                case 2:
                    tabela = "select * from funcionario inner join pessoa on pessoa.id_pessoa = funcionario.id_pessoa ";

                    break;
                case 3:
                    tabela = "select * from fornecedor inner join pessoa_juridica on pessoa.id_pessoa_juridica = fornecedor.id_pessoa_juridica ";

                    break;
                case 4:
                    tabela = "select * from produto ";
                    
                    break;
                case 5:

                    break;
                case 6:
                    tabela = "select * from medicamentos ";

                    break;
            }
        }

        private void comboBoxPesqPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmPesquisas_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

            Estatica.tipoAcao = TipoAcao.alterar;
            /*
             * Clientes
             * Animais
             * Funcionários
             * Fornecedores
             * Produtos
             * Medicamentos
             */
            switch (comboBoxTipo.SelectedIndex)
            {
                case 0:
                    FrmCadastroCliente cliente = new FrmCadastroCliente();
                    cliente.ShowDialog();

                    break;
                case 1:
                    
                    FrmAnimal animal = new FrmAnimal();
                    animal.ShowDialog();
                    break;

                case 2:
                    FrmFuncionario funcionario = new FrmFuncionario();
                    funcionario.ShowDialog();
                    break;

                case 3:
                    FrmFornecedor fornecedor = new FrmFornecedor();
                    fornecedor.ShowDialog();
                    break;

                case 4:
                    FrmProduto produto = new FrmProduto();
                    produto.ShowDialog();
                    break;

                case 5:
                    FrmRemedio remedio = new FrmRemedio();
                    remedio.ShowDialog();
                    break;
                
            }
        }

        private void dataGridViewPesquisas_SelectionChanged(object sender, EventArgs e)
        {
            Estatica.id = Convert.ToInt32(dataGridViewPesquisas.CurrentRow.Cells[0].Value.ToString());
        }

        private void buttonSelecinar_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
