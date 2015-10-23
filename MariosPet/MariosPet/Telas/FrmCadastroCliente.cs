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
    public partial class FrmCadastroCliente : Form
    {
        Endereco classeEnd = new Endereco();
        Cliente classeCli = new Cliente();
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btmLimpar_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Clear();
            txtBairroCliente.Clear();
            txtCidadeCliente.Clear();
            txtComplementoCliente.Clear();
            txtEmailCliente.Clear();
            txtNumeroCliente.Clear();
            txtRuaCliente.Clear();
            txtTelefone2Cliente.Clear();
            txtTelefone3Cliente.Clear();
            txtTelefoneCliente.Clear();
            mskCepCliente.Clear();
            mskNascimentoCliente.Clear();
            mstCPF.Clear();
            mstRG.Clear();
        }

        private void btmVoltar_Click(object sender, EventArgs e)
        {
            Telas.FrmMenu frmmenu = new FrmMenu();
            frmmenu.Show();
            Close();
        }

        public void CopiarParaClasseCliente()
        {
            //Endereço
            classeEnd.rua = txtRuaCliente.Text;
            classeEnd.numero = txtNumeroCliente.Text;
            classeEnd.complemento = txtComplementoCliente.Text;
            classeEnd.bairro = txtBairroCliente.Text;
            classeEnd.cep = mskCepCliente.Text;
            classeEnd.cidade = txtCidadeCliente.Text;
            classeEnd.uf = cmbUFCliente.Text;

            //Dados Pessoais
            classeCli.nome = txtNomeCliente.Text;
            classeCli.nascimento = mskNascimentoCliente.Text;
            classeCli.cpf = mstCPF.Text;
            classeCli.rg = mstRG.Text;
            classeCli.email = txtEmailCliente.Text;
            classeCli.telefone1 = txtTelefoneCliente.Text;
            classeCli.telefone2 = txtTelefone2Cliente.Text;
            classeCli.telefone3 = txtTelefone3Cliente.Text;
        }

        private void btmSalvar_Click_1(object sender, EventArgs e)
        {
            CopiarParaClasseCliente();

            CrudCliente CrudCli = new CrudCliente();
            CrudEndereco CrudEnd = new CrudEndereco();

            CrudEnd.inserirEndereco(classeEnd);

            classeCli.idEndereco = Convert.ToInt32(CrudEnd.consultaEndereco("select top 1 ID_ENDERECO from ENDERECO order by ID_ENDERECO desc").Rows[0][0].ToString());

            CrudCli.inserirCliente(classeCli);
            
        }
    }
}
