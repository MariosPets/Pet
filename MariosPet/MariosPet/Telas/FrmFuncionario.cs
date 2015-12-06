using MariosPet.Classes;
using MariosPet.Crud;
using System;
using System.Data;
using System.Windows.Forms;

namespace MariosPet.Telas
{
    public partial class FrmFuncionario : Form
    {
        Funcionario classeFunc = new Funcionario();
        Veterinario classeVete = new Veterinario();
        Endereco classeEnd = new Endereco();
        public FrmFuncionario()
        {
            InitializeComponent();

            if (Estatica.id != 0)
            {
                CopiarParaFormulario();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBairroFuncionario.Clear();
            txtCidadeFuncionario.Clear();
            txtComplementoFuncionario.Clear();
            txtConfirmacaoSenha.Clear();
            txtEmailFuncionario.Clear();
            txtLogin.Clear();
            txtNomeFuncionario.Clear();
            txtNumeroFuncionario.Clear();
            txtRuaFuncionario.Clear();
            txtSenha.Clear();
            txtTelefone2Funcionario.Clear();
            txtTelefone3Funcionario.Clear();
            txtTelefoneFuncionario.Clear();
            mstCepFuncionario.Clear();
            mstCPFFuncionario.Clear();
            mstNascimentoFuncionario.Clear();
            mstRGFuncionario.Clear();
            txtCrmv.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void CopiarParaClasseFuncionario()
        {
            if (!txtCrmv.Enabled)
            {
                //Pessoa
                classeFunc.nome = txtNomeFuncionario.Text;
                classeFunc.nascimento = mstNascimentoFuncionario.Text;
                classeFunc.cpf = mstCPFFuncionario.Text;
                classeFunc.rg = mstRGFuncionario.Text;
                classeFunc.email = txtEmailFuncionario.Text;
                classeFunc.telefone1 = txtTelefoneFuncionario.Text;
                classeFunc.telefone2 = txtTelefone2Funcionario.Text;
                classeFunc.telefone3 = txtTelefone3Funcionario.Text;

                //Funcionario
                classeFunc.tipo = cmbTipoFuncionario.Text;
                classeFunc.apelido = txtLogin.Text;
                classeFunc.senha = txtSenha.Text;
            }
            else
            {
                classeVete.nome = txtNomeFuncionario.Text;
                classeVete.nascimento = mstNascimentoFuncionario.Text;
                classeVete.cpf = mstCPFFuncionario.Text;
                classeVete.rg = mstRGFuncionario.Text;
                classeVete.email = txtEmailFuncionario.Text;
                classeVete.telefone1 = txtTelefoneFuncionario.Text;
                classeVete.telefone2 = txtTelefone2Funcionario.Text;
                classeVete.telefone3 = txtTelefone3Funcionario.Text;
                classeVete.crmv = Convert.ToInt32(txtCrmv.Text);

                //Veterinario
                classeVete.tipo = cmbTipoFuncionario.Text;
                classeVete.apelido = txtLogin.Text;
                classeVete.senha = txtSenha.Text;
            }

            //Endereço
            classeEnd.rua = txtRuaFuncionario.Text;
            classeEnd.numero = txtNumeroFuncionario.Text;
            classeEnd.complemento = txtComplementoFuncionario.Text;
            classeEnd.bairro = txtBairroFuncionario.Text;
            classeEnd.cep = mstCepFuncionario.Text;
            classeEnd.cidade = txtCidadeFuncionario.Text;
            classeEnd.uf = cmbUFFuncionario.Text;
        }

        public void CopiarParaFormulario()
        {
            CrudFuncionario CrudFunc = new CrudFuncionario();
            CrudVeterinario CrudVet = new CrudVeterinario();
            CrudEndereco CrudEnd = new CrudEndereco();

            string sql = "select * from pessoa inner join funcionario on pessoa.id_pessoa = funcionario.id_pessoa inner join veterinario on veterinario.id_funcionario = funcionario.id_pessoa where veterinario.id_funcionario = " + Estatica.id.ToString();

            DataTable veterinario = CrudVet.consultaVeterinario(sql);

            if (veterinario.Rows.Count > 0)
            {
                //Dados Veterinario
                txtCrmv.Text = veterinario.Rows[0][15].ToString();

                txtNomeFuncionario.Text = veterinario.Rows[0][1].ToString();
                mstCPFFuncionario.Text = veterinario.Rows[0][2].ToString();
                mstRGFuncionario.Text = veterinario.Rows[0][3].ToString();
                mstNascimentoFuncionario.Text = veterinario.Rows[0][4].ToString();
                txtEmailFuncionario.Text = veterinario.Rows[0][6].ToString();
                txtTelefoneFuncionario.Text = veterinario.Rows[0][7].ToString();
                txtTelefone2Funcionario.Text = veterinario.Rows[0][8].ToString();
                txtTelefone3Funcionario.Text = veterinario.Rows[0][9].ToString();
                cmbTipoFuncionario.Text = veterinario.Rows[0][11].ToString();
                txtLogin.Text = veterinario.Rows[0][12].ToString();
                txtSenha.Text = veterinario.Rows[0][13].ToString();
                txtConfirmacaoSenha.Text = veterinario.Rows[0][13].ToString();

                sql = "select * from endereco where id_endereco = " + veterinario.Rows[0][5].ToString();
            }
            else
            {
                sql = "select * from pessoa inner join funcionario on pessoa.id_pessoa = funcionario.id_pessoa where funcionario.id_pessoa = " + Estatica.id.ToString();

                DataTable funcionario = CrudFunc.consultaFuncionario(sql);

                //Dados Funcionário Normal
                txtNomeFuncionario.Text = funcionario.Rows[0][1].ToString();
                mstCPFFuncionario.Text = funcionario.Rows[0][2].ToString();
                mstRGFuncionario.Text = funcionario.Rows[0][3].ToString();
                mstNascimentoFuncionario.Text = funcionario.Rows[0][4].ToString();
                txtEmailFuncionario.Text = funcionario.Rows[0][6].ToString();
                txtTelefoneFuncionario.Text = funcionario.Rows[0][7].ToString();
                txtTelefone2Funcionario.Text = funcionario.Rows[0][8].ToString();
                txtTelefone3Funcionario.Text = funcionario.Rows[0][9].ToString();
                cmbTipoFuncionario.Text = funcionario.Rows[0][11].ToString();
                txtLogin.Text = funcionario.Rows[0][12].ToString();
                txtSenha.Text = funcionario.Rows[0][13].ToString();
                txtConfirmacaoSenha.Text = funcionario.Rows[0][13].ToString();

                sql = "select * from endereco where id_endereco = " + funcionario.Rows[0][5].ToString();
            }

            DataTable endereco = CrudEnd.consultaEndereco(sql);

            txtRuaFuncionario.Text = endereco.Rows[0][1].ToString();
            txtNumeroFuncionario.Text = endereco.Rows[0][2].ToString();
            txtComplementoFuncionario.Text = endereco.Rows[0][3].ToString();
            txtBairroFuncionario.Text = endereco.Rows[0][4].ToString();
            txtCidadeFuncionario.Text = endereco.Rows[0][5].ToString();
            cmbUFFuncionario.Text = endereco.Rows[0][6].ToString();
            mstCepFuncionario.Text = endereco.Rows[0][7].ToString();            
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            CopiarParaClasseFuncionario();

            CrudEndereco CrudEnd = new CrudEndereco();
            CrudFuncionario CrudFunc = new CrudFuncionario();
            CrudVeterinario CrudVete = new CrudVeterinario();

            if (Estatica.id != 0)
            {
                if (!txtCrmv.Enabled)
                {
                    CrudFunc.alteraFuncionario(classeFunc);
                }
                else
                {
                    CrudVete.alteraVeterinario(classeVete);
                }
                Estatica.id = 0;
                MessageBox.Show("Funcionário Alterado com Sucesso", "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                CrudEnd.inserirEndereco(classeEnd);

                if (!txtCrmv.Enabled)
                {
                    classeFunc.idEndereco = Convert.ToInt32(CrudEnd.consultaEndereco("select top 1 ID_ENDERECO from ENDERECO order by ID_ENDERECO desc").Rows[0][0].ToString());

                    CrudFunc.inserirFuncionario(classeFunc);
                }
                else
                {
                    classeVete.idEndereco = Convert.ToInt32(CrudEnd.consultaEndereco("select top 1 ID_ENDERECO from ENDERECO order by ID_ENDERECO desc").Rows[0][0].ToString());

                    CrudVete.inserirVeterinario(classeVete);

                }
                MessageBox.Show("Funcionário Cadastrado com Sucesso", "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbTipoFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoFuncionario.Text.Equals("Veterinário(a)"))
            {
                txtCrmv.Enabled = true;
                lblCrmv.Enabled = true;
            }
            else
            {
                txtCrmv.Enabled = false;
                lblCrmv.Enabled = false;
            }
        }
    }
}
