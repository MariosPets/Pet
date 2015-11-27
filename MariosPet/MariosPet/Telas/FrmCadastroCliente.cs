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

            if (Estatica.id != 0)
            {
                CopiarParaFormulario();
            }
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

        private void CopiarParaFormulario()
        {
            CrudCliente CrudCli = new CrudCliente();
            CrudEndereco CrudEnd = new CrudEndereco();

            string sql = "select * from pessoa inner join cliente on pessoa.id_pessoa = cliente.id_pessoa where pessoa.id_pessoa = " + Estatica.id.ToString();
            DataTable cliente = CrudCli.consultaCliente(sql);

            //Dados Pessoais
            classeCli.id = Convert.ToInt32(cliente.Rows[0][0].ToString());
            txtNomeCliente.Text = cliente.Rows[0][1].ToString();
            mstCPF.Text = cliente.Rows[0][2].ToString();
            mstRG.Text = cliente.Rows[0][3].ToString();
            mskNascimentoCliente.Text = cliente.Rows[0][4].ToString();
            classeCli.idEndereco = Convert.ToInt32(cliente.Rows[0][5].ToString());
            classeEnd.id = Convert.ToInt32(cliente.Rows[0][5].ToString());
            txtEmailCliente.Text = cliente.Rows[0][6].ToString();
            txtTelefoneCliente.Text = cliente.Rows[0][7].ToString();
            txtTelefone2Cliente.Text = cliente.Rows[0][8].ToString();
            txtTelefone3Cliente.Text = cliente.Rows[0][9].ToString();

            sql = "select * from endereco where id_endereco = " + cliente.Rows[0][5].ToString();
            DataTable endereco = CrudEnd.consultaEndereco(sql);

            txtRuaCliente.Text = endereco.Rows[0][1].ToString();
            txtNumeroCliente.Text = endereco.Rows[0][2].ToString();
            txtComplementoCliente.Text = endereco.Rows[0][3].ToString();
            txtBairroCliente.Text = endereco.Rows[0][4].ToString();
            txtCidadeCliente.Text = endereco.Rows[0][5].ToString();
            cmbUFCliente.Text = endereco.Rows[0][6].ToString();
            mskCepCliente.Text = endereco.Rows[0][7].ToString();
        }

        private void btmSalvar_Click_1(object sender, EventArgs e)
        {
            CopiarParaClasseCliente();

            CrudCliente CrudCli = new CrudCliente();
            CrudEndereco CrudEnd = new CrudEndereco();

            if (Estatica.id != 0)
            {
                CrudEnd.alteraEndereco(classeEnd);
                CrudCli.alteraCliente(classeCli);
                Estatica.id = 0;
            }
            else
            {
                CrudEnd.inserirEndereco(classeEnd);

                classeCli.idEndereco = Convert.ToInt32(CrudEnd.consultaEndereco("select top 1 ID_ENDERECO from ENDERECO order by ID_ENDERECO desc").Rows[0][0].ToString());

                CrudCli.inserirCliente(classeCli);
            }
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            
        }
    }
}
