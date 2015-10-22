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
    public partial class FrmProduto : Form
    {
        Produto classeProd = new Produto();
        Fornecedor classeForn = new Fornecedor();
        PessoaJuridica classePessoaJur = new PessoaJuridica();
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void lblRG_Click(object sender, EventArgs e)
        {

        }

        private void mstCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btmLimpar_Click(object sender, EventArgs e)
        {
            txtMargemLucro.Clear();
            txtMaxEstoque.Clear();
            txtMinEstoque.Clear();
            txtNomeProduto.Clear();
            txtQuantidade.Clear();
            txtTributacao.Clear();
            txtUnidade.Clear();
            txtCodBarras.Clear();
            txtFabricante.Clear();
            txtValorCusto.Clear();
            txtValorVenda.Clear();
            mstVencimento.Clear();
        }

        private void btmVoltar_Click(object sender, EventArgs e)
        {
            Telas.FrmMenu frmmenu = new FrmMenu();
            frmmenu.Show();
            Close();
        }

        public void CopiarParaClasseProduto()
        {
            //Produto
            classeProd.descricao = txtNomeProduto.Text;
            classeProd.setor = cmbSetor.Text;
            classeProd.vencimento = DateTime.Parse(mstVencimento.Text);
            classeProd.quantidade = Convert.ToInt32(txtQuantidade.Text);
            classeProd.unidade = txtUnidade.Text;
            classeProd.valorCusto = Convert.ToDouble(txtValorCusto.Text);
            classeProd.valorVenda = Convert.ToDouble(txtValorVenda.Text);
            classeProd.lucro = Convert.ToDouble(txtMargemLucro.Text);
            classeProd.minimoEmEstoque = Convert.ToInt32(txtMinEstoque.Text);
            classeProd.maximoEmEstoque = Convert.ToInt32(txtMaxEstoque.Text);
            classeProd.tributacao = txtTributacao.Text;
            classeProd.codigoBarras = txtCodBarras.Text;
            classeProd.fabricante = txtFabricante.Text;

            //Pessoa Juridica
            classePessoaJur.razaoSocial = textBoxFornecedor.Text;
        }

        private void btmSalvar_Click(object sender, EventArgs e)
        {
            CopiarParaClasseProduto();

            CrudProduto CrudProd = new CrudProduto();
            CrudPessoaJuridica CrudPessoaJur = new CrudPessoaJuridica();

            CrudProd.inserirProduto(classeProd);
            CrudPessoaJur.inserirPessoaJuridica(classePessoaJur);
        }
    }
}
