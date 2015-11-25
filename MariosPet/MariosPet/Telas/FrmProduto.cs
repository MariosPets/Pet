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

        CrudProduto CrudProd = new CrudProduto();
        CrudFornecedor CrudForn = new CrudFornecedor();
        public FrmProduto()
        {
            InitializeComponent();

            if (Estatica.id != 0)
            {
                CopiarParaFormulario();
            }
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

        public void CopiarParaFormulario()
        {
            string sql = "select * from produto where id_produto = " + Estatica.id.ToString();
            DataTable produto = CrudProd.consultaProduto(sql);

            //Dados Produto
            classeProd.id = Convert.ToInt32(produto.Rows[0][0].ToString());
            txtNomeProduto.Text = produto.Rows[0][1].ToString();
            cmbSetor.Text = produto.Rows[0][2].ToString();
            classeProd.idFornecedor = Convert.ToInt32(produto.Rows[0][3].ToString());
            txtFabricante.Text = produto.Rows[0][4].ToString();
            mstVencimento.Text = produto.Rows[0][5].ToString();
            txtQuantidade.Text = produto.Rows[0][6].ToString();
            txtUnidade.Text = produto.Rows[0][7].ToString();
            txtValorCusto.Text = produto.Rows[0][8].ToString();
            txtValorVenda.Text = produto.Rows[0][9].ToString();
            txtMargemLucro.Text = produto.Rows[0][10].ToString();
            txtTributacao.Text = produto.Rows[0][11].ToString();
            txtMinEstoque.Text = produto.Rows[0][12].ToString();
            txtMaxEstoque.Text = produto.Rows[0][13].ToString();
            txtCodBarras.Text = produto.Rows[0][14].ToString();
                        
            sql = "select * from pessoa_juridica inner join fornecedor on pessoa_juridica.id_pessoa_juridica = fornecedor.id_pessoa_juridica where pessoa_juridica.id_pessoa_juridica = " + Estatica.id.ToString();
            DataTable fornecedor = CrudForn.consultaFornecedor(sql);

            //Fornecedor
            textBoxFornecedor.Text = produto.Rows[0][1].ToString();

        }

        private void btmSalvar_Click(object sender, EventArgs e)
        {
            CopiarParaClasseProduto();

            CrudProduto CrudProd = new CrudProduto();
            CrudFornecedor CrudForn = new CrudFornecedor();

            if (Estatica.id != 0)
            {
                CrudProd.alteraProduto(classeProd);
                CrudForn.alteraFornecedor(classeForn);
                Estatica.id = 0;
            }
            else
            {
                CrudProd.inserirProduto(classeProd);                               

                classeForn.id = Convert.ToInt32(CrudForn.consultaFornecedor("Select top 1 ID_FORNECEDOR from FORNECEDOR order by ID_FORNECEDOR desc").Rows[0][0].ToString());

                CrudForn.inserirFornecedor(classeForn); 
            }
        }
    }
}
