using MariosPet.Classes;
using MariosPet.Crud;
using System;
using System.Data;
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

            if (Estatica.id != 0)
            {
                CopiarParaFormulario();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDenominacao.Clear();
            mstCNPJ.Clear();
            txtAtividade.Clear();
            txtTelefone.Clear();
            txtTelefone2.Clear();
            textBoxEmail1.Clear();
            textBoxEmail2.Clear();
            textBoxNomeContato.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            maskedTextBoxCep.Clear();
            txtCidade.Clear(); 
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

        public void CopiarParaFormulario()
        {
            CrudFornecedor CrudForn = new CrudFornecedor();
            CrudEndereco CrudEnd = new CrudEndereco();

            string sql = "select * from pessoa_juridica inner join fornecedor on pessoa_juridica.id_pessoa_juridica = fornecedor.id_pessoa_juridica where pessoa_juridica.id_pessoa_juridica = " + Estatica.id.ToString();

            DataTable fornecedor = CrudForn.consultaFornecedor(sql);

            //Dados Fornecedor
            classeForn.id = Convert.ToInt32(fornecedor.Rows[0][0].ToString());
            txtAtividade.Text = fornecedor.Rows[0][1].ToString();
            textBoxNomeContato.Text = fornecedor.Rows[0][2].ToString();

            //Dados Pessoa Jurídica
            txtDenominacao.Text = fornecedor.Rows[0][1].ToString();
            mstCNPJ.Text = fornecedor.Rows[0][2].ToString();
            classeForn.idEndereco = Convert.ToInt32(fornecedor.Rows[0][3].ToString());
            textBoxEmail1.Text = fornecedor.Rows[0][4].ToString();
            textBoxEmail2.Text = fornecedor.Rows[0][5].ToString();
            txtTelefone.Text = fornecedor.Rows[0][6].ToString();
            txtTelefone2.Text = fornecedor.Rows[0][7].ToString();

            sql = "select * from endereco where id_endereco = " + fornecedor.Rows[0][3].ToString();
            DataTable endereco = CrudEnd.consultaEndereco(sql);

            //Endereço
            txtRua.Text = endereco.Rows[0][1].ToString();
            txtNumero.Text = endereco.Rows[0][2].ToString();
            txtComplemento.Text = endereco.Rows[0][3].ToString();
            txtBairro.Text = endereco.Rows[0][4].ToString();
            txtCidade.Text = endereco.Rows[0][5].ToString();
            cmbUF.Text = endereco.Rows[0][6].ToString();
            maskedTextBoxCep.Text = endereco.Rows[0][7].ToString();  
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CopiarParaClasseFornecedor();
            CrudEndereco CrudEnd = new CrudEndereco();
            CrudFornecedor CrudForn = new CrudFornecedor();

            if (Estatica.id != 0)
            {                
                CrudEnd.alteraEndereco(classeEnd);
                CrudForn.alteraFornecedor(classeForn);
                Estatica.id = 0;
            }
            else
            {
                CrudEnd.inserirEndereco(classeEnd);

                classeForn.idEndereco = Convert.ToInt32(CrudEnd.consultaEndereco("select top 1 ID_ENDERECO from ENDERECO order by ID_ENDERECO desc").Rows[0][0].ToString());

                CrudForn.inserirFornecedor(classeForn);
            }
        }
    }
}
