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
    public partial class FrmFornecedor : Form
    {
        Endereco classeEnd = new Endereco();
        Fornecedor classeForn = new Fornecedor();
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Telas.FrmMenu menu = new FrmMenu();
            menu.Show();
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAtividade.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtDenominacao.Clear();
            txtNumero.Clear();
            txtRua.Clear();
            txtTelefone.Clear();
            txtTelefone2.Clear();

        }

        public void CopiarParaClasseFornecedor()
        {
            //Fornecedor
            classeForn.ramoAtividade = txtAtividade.Text;
            classeForn.nomeContato = textBoxNomeContato.Text;

            //Pessoa Jurídica
            classeForn.razaoSocial = txtDenominacao.Text;
            classeForn.cnpj = mstCNPJ.Text;
            classeForn.telefone1 = txtTelefone.Text;
            classeForn.telefone2 = txtTelefone2.Text;
            classeForn.email1 = textBoxEmail1.Text;
            classeForn.email2 = textBoxEmail2.Text;

            //Endereço
            classeEnd.rua = txtRua.Text;
            classeEnd.numero = txtNumero.Text;
            classeEnd.complemento = txtComplemento.Text;
            classeEnd.bairro = txtBairro.Text;
            classeEnd.cep = mstCNPJ.Text;
            classeEnd.cidade = txtCidade.Text;
            classeEnd.uf = cmbUF.Text;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CopiarParaClasseFornecedor();

            CrudEndereco CrudEnd = new CrudEndereco();
            CrudFornecedor CrudForn = new CrudFornecedor();

            CrudEnd.inserirEndereco(classeEnd);

            classeForn.idEndereco = Convert.ToInt32(CrudEnd.consultaEndereco("select top 1 ID_ENDERECO from ENDERECO order by ID_ENDERECO desc").Rows[0][0].ToString());

            CrudForn.inserirFornecedor(classeForn);
        }
    }
}
