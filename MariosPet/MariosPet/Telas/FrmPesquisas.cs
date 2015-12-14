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
            dataGridViewPesquisas.DataSource = CrudCli.consultaCliente(tabela+condicao);

        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPesqPor.Items.Clear();

            switch (comboBoxTipo.SelectedIndex) { 
                case 0:
                    tabela = "select * from cliente inner join pessoa on pessoa.id_pessoa = cliente.id_pessoa ";
                    
                    comboBoxPesqPor.Items.Insert(0, "Nome");
                    comboBoxPesqPor.Items.Insert(1, "CPF");
                    comboBoxPesqPor.Items.Insert(2, "RG");
                    comboBoxPesqPor.Items.Insert(3, "Data de Nascimento");

                    break;
                case 1:
                    tabela = "select * from animal ";

                    comboBoxPesqPor.Items.Insert(0, "Carteirinha");
                    comboBoxPesqPor.Items.Insert(1, "Nome");
                    comboBoxPesqPor.Items.Insert(2, "Raça / Porte");
                    comboBoxPesqPor.Items.Insert(3, "Sexo");
                    comboBoxPesqPor.Items.Insert(4, "Pelagem / Cor");
                    comboBoxPesqPor.Items.Insert(4, "Data de Nascimento");

                    break;
                case 2:
                    tabela = "select * from laboratorio inner join pessoa_juridica on pessoa_juridica.id_pessoa_juridica = laboratorio.id_pessoa_juridica ";

                    comboBoxPesqPor.Items.Insert(0, "Razão Social");
                    comboBoxPesqPor.Items.Insert(1, "CNPJ");

                    break;
                case 3:
                    tabela = "select * from medicamento ";

                    comboBoxPesqPor.Items.Insert(0, "Descrição");

                    break;
                case 4:
                    
                    break;
                case 5:

                    break;
                case 6:
                    tabela = "select * from produto ";

                    comboBoxPesqPor.Items.Insert(0, "Descrição");
                    comboBoxPesqPor.Items.Insert(1, "Setor");
                    comboBoxPesqPor.Items.Insert(2, "Nome de Contato");

                    break;
                case 7:
                    tabela = "select * from servico ";

                    comboBoxPesqPor.Items.Insert(0, "Descrição");

                    break;
                case 8:
                    tabela = "select * from fornecedor inner join pessoa_juridica on pessoa_juridica.id_pessoa_juridica = fornecedor.id_pessoa_juridica ";

                    comboBoxPesqPor.Items.Insert(0, "Ramo de Atividade");
                    comboBoxPesqPor.Items.Insert(1, "Nome do Contato");
                    comboBoxPesqPor.Items.Insert(2, "Razão Social");
                    comboBoxPesqPor.Items.Insert(3, "CNPJ");

                    break;
                case 9:

                    break;
                case 10:
                    tabela = "select * from funcionario inner join pessoa on pessoa.id_pessoa = funcionario.id_pessoa ";

                    comboBoxPesqPor.Items.Insert(0, "Nome");
                    comboBoxPesqPor.Items.Insert(1, "CPF");
                    comboBoxPesqPor.Items.Insert(2, "RG");
                    comboBoxPesqPor.Items.Insert(3, "Data de Nascimento");
                    comboBoxPesqPor.Items.Insert(4, "Cargo");

                    break;
            }
        }

        private void comboBoxPesqPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            condicao = "";

            switch (comboBoxTipo.SelectedIndex)
            {
                case 0:

                    switch (comboBoxPesqPor.SelectedIndex)
                    {
                        case 0:
                            condicao = "where nome like('%"+txtPesquisa.Text+"%')";
                            break;
                        case 1:
                            condicao = "where cpf like('%" + txtPesquisa.Text + "%')";
                            break;
                        case 2:
                            condicao = "where rg like('%" + txtPesquisa.Text + "%')";
                            break;
                        case 3:
                            condicao = "where nascimento like('%" + txtPesquisa.Text + "%')";
                            break;
                    }

                    break;
                case 1:

                    switch (comboBoxPesqPor.SelectedIndex)
                    {
                        case 0:
                            condicao = "where carteirinha like('%" + txtPesquisa.Text + "%')";
                            break;
                        case 1:
                            condicao = "where nome like('%" + txtPesquisa.Text + "%')";
                            break;
                        case 2:
                            condicao = "where raca_porte like('%" + txtPesquisa.Text + "%')";
                            break;
                        case 3:
                            condicao = "where sexo like('%" + txtPesquisa.Text + "%')";
                            break;
                        case 4:
                            condicao = "where pelagem_cor like('%" + txtPesquisa.Text + "%')";
                            break;
                        case 5:
                            condicao = "where nascimento like('%" + txtPesquisa.Text + "%')";
                            break;
                    }

                    break;
                case 2:

                    switch (comboBoxPesqPor.SelectedIndex)
                    {
                        case 0:
                            condicao = "where razao_social like('%" + txtPesquisa.Text + "%')";
                            break;
                        case 1:
                            condicao = "where cnpj like('%" + txtPesquisa.Text + "%')";
                            break;
                    }

                    break;
                case 3:

                    switch (comboBoxPesqPor.SelectedIndex)
                    {
                        case 0:
                            condicao = "where descricao like('%" + txtPesquisa.Text + "%')";
                            break;
                    }

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    switch (comboBoxPesqPor.SelectedIndex)
                    {

                        case 0:
                            condicao = "where descricao like('%" + txtPesquisa.Text + "%')";
                            break;
                        case 1:
                            condicao = "where setor like('%" + txtPesquisa.Text + "%')";
                            break;
                        case 2:
                            condicao = "where nome_contato like('%" + txtPesquisa.Text + "%')";
                            break;
                    }

                    break;
                case 7:

                    switch (comboBoxPesqPor.SelectedIndex)
                    {
                        case 0:
                            condicao = "where descricao like('%" + txtPesquisa.Text + "%')";
                            break;
                    }
                    
                    break;
                case 8:

                    switch (comboBoxPesqPor.SelectedIndex)
                    {

                        case 0:
                            condicao = "where ramo_atividade like('%" + txtPesquisa.Text + "%')";
                            break;
                        case 1:
                            condicao = "where nome_contato like('%" + txtPesquisa.Text + "%')";
                            break;
                        case 2:
                            condicao = "where razao_social like('%" + txtPesquisa.Text + "%')";
                            break;
                        case 3:
                            condicao = "where cnpj like('%" + txtPesquisa.Text + "%')";
                            break;
                    }

                    break;
                case 9:

                    break;
                case 10:

                    switch (comboBoxPesqPor.SelectedIndex)
                    {
                        case 0:
                            condicao = "where nome like('%" + txtPesquisa.Text + "%')";
                            break;
                        case 1:
                            condicao = "where cpf like('%" + txtPesquisa.Text + "%')";
                            break;
                        case 2:
                            condicao = "where rg like('%" + txtPesquisa.Text + "%')";
                            break;
                        case 3:
                            condicao = "where nascimento like('%" + txtPesquisa.Text + "%')";
                            break;
                        case 4:
                            condicao = "where tipo like('%" + txtPesquisa.Text + "%')";
                            break;
                    }
                    
                    break;

            }
        }

        private void FrmPesquisas_Load(object sender, EventArgs e)
        {
            comboBoxTipo.SelectedIndex = 0;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Estatica.tipoAcao = TipoAcao.alterar;

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
                    FrmLaboratorio laboratorio = new FrmLaboratorio();
                    laboratorio.ShowDialog();
                    break;
                case 3:
                    
                    FrmRemedio remedio = new FrmRemedio();
                    remedio.ShowDialog();
                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:
                    FrmProduto produto = new FrmProduto();
                    produto.ShowDialog();
                    break;
                case 7:
                    FrmServico servico = new FrmServico();
                    servico.ShowDialog();
                    break;
                case 8:
                    
                    FrmFornecedor fornecedor = new FrmFornecedor();
                    fornecedor.ShowDialog();
                    break;
                case 9:

                    break;
                case 10:
                    
                    FrmFuncionario funcionario = new FrmFuncionario();
                    funcionario.ShowDialog();
                    break;
            }
        }

        private void dataGridViewPesquisas_SelectionChanged(object sender, EventArgs e)
        {
            lblConsulta.Text = dataGridViewPesquisas.CurrentRow.Cells[0].Value.ToString();
            Estatica.id = Convert.ToInt32(dataGridViewPesquisas.CurrentRow.Cells[0].Value.ToString());
        }

        private void buttonSelecinar_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
