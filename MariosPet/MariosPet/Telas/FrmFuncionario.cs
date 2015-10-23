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
    public partial class FrmFuncionario : Form
    {
        Funcionario classeFunc = new Funcionario();
        Endereco classeEnd = new Endereco();
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Telas.FrmMenu frmmenu = new FrmMenu();
            frmmenu.Show();
            Close();
        }

        public void CopiarParaClasseFuncionario()
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

            //Endereço
            classeEnd.rua = txtRuaFuncionario.Text;
            classeEnd.numero = txtNumeroFuncionario.Text;
            classeEnd.complemento = txtComplementoFuncionario.Text;
            classeEnd.bairro = txtBairroFuncionario.Text;
            classeEnd.cep = mstCepFuncionario.Text;
            classeEnd.cidade = txtCidadeFuncionario.Text;
            classeEnd.uf = cmbUFFuncionario.Text;

            //Funcionario
            classeFunc.tipo = cmbTipoFuncionario.Text;
            classeFunc.apelido = txtLogin.Text;
            classeFunc.senha = txtSenha.Text;
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            CopiarParaClasseFuncionario();

            CrudEndereco CrudEnd = new CrudEndereco();
            CrudFuncionario CrudFunc = new CrudFuncionario();

            CrudEnd.inserirEndereco(classeEnd);

            classeFunc.idEndereco = Convert.ToInt32(CrudEnd.consultaEndereco("select top 1 ID_ENDERECO from ENDERECO order by ID_ENDERECO desc").Rows[0][0].ToString());

            CrudFunc.inserirFuncionario(classeFunc);
        }
    }
}
