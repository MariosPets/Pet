using MariosPet.Classes;
using MariosPet.Crud;
using System;
using System.Data;
using System.Windows.Forms;

namespace MariosPet.Telas
{
    public partial class FrmLaboratorio : Form
    {
        Endereco classeEnd = new Endereco();
        Laboratorio classeLab = new Laboratorio();

        CrudLaboratorio CrudLab = new CrudLaboratorio();
        CrudEndereco CrudEnd = new CrudEndereco();
        public FrmLaboratorio()
        {
            InitializeComponent();
            if (Estatica.id != 0)
            {
                CopiarParaFormulario();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBairro.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtEmail1.Clear();
            txtEmail2.Clear();
            txtNomeLaboratorio.Clear();
            txtNumero.Clear();
            txtRua.Clear();
            txtTelefone1.Clear();
            txtTelefone2.Clear();
            mstCep.Clear();
            mstCNPJ.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void CopiarParaClasseLaboratorio()
        {
            //Endereco
            classeEnd.rua = txtRua.Text;
            classeEnd.numero = txtNumero.Text;
            classeEnd.complemento = txtComplemento.Text;
            classeEnd.bairro = txtBairro.Text;
            classeEnd.cep = mstCep.Text;
            classeEnd.cidade = txtCidade.Text;
            classeEnd.uf = cmbUF.Text;

            //Dados do Laboratório
            classeLab.razaoSocial = txtNomeLaboratorio.Text;
            classeLab.cnpj = mstCNPJ.Text;
            classeLab.telefone1 = txtTelefone1.Text;
            classeLab.telefone2 = txtTelefone2.Text;
            classeLab.email1 = txtEmail1.Text;
            classeLab.email2 = txtEmail2.Text;
        }

        public void CopiarParaFormulario()
        {            
            string sql = "select * from pessoa_juridica inner join laboratorio on pessoa_juridica.id_pessoa_juridica = laboratorio.id_pessoa_juridica where pessoa_juridica.id_pessoa_juridica = " + Estatica.id.ToString();
            DataTable laboratorio = CrudLab.consultaLaboratorio(sql);
            
            //Dados Laboratorio
            classeLab.id = Convert.ToInt32(laboratorio.Rows[0][0].ToString());
            txtNomeLaboratorio.Text = laboratorio.Rows[0][1].ToString();
            mstCNPJ.Text = laboratorio.Rows[0][2].ToString();
            classeLab.idEndereco = Convert.ToInt32(laboratorio.Rows[0][3].ToString());
            classeEnd.id = Convert.ToInt32(laboratorio.Rows[0][3].ToString());
            txtEmail1.Text = laboratorio.Rows[0][4].ToString();
            txtEmail2.Text = laboratorio.Rows[0][5].ToString();
            txtTelefone1.Text = laboratorio.Rows[0][6].ToString();
            txtTelefone2.Text = laboratorio.Rows[0][7].ToString();
                        
            sql = "select * from endereco where id_endereco = " + laboratorio.Rows[0][3].ToString();
            DataTable endereco = CrudEnd.consultaEndereco(sql);

            //Endereço
            txtRua.Text = endereco.Rows[0][1].ToString();
            txtNumero.Text = endereco.Rows[0][2].ToString();
            txtComplemento.Text = endereco.Rows[0][3].ToString();
            txtBairro.Text = endereco.Rows[0][4].ToString();
            txtCidade.Text = endereco.Rows[0][5].ToString();
            cmbUF.Text = endereco.Rows[0][6].ToString();
            mstCep.Text = endereco.Rows[0][7].ToString();            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CopiarParaClasseLaboratorio();

            if (Estatica.id != 0)
            {
                CrudEnd.alteraEndereco(classeEnd);
                CrudLab.alteraLaboratorio(classeLab);
                Estatica.id = 0;
            }
            else
            {
                CrudEnd.inserirEndereco(classeEnd);

                classeLab.idEndereco = Convert.ToInt32(CrudEnd.consultaEndereco("select top 1 ID_ENDERECO from ENDERECO order by ID_ENDERECO desc").Rows[0][0].ToString());

                CrudLab.inserirLaboratorio(classeLab);
            }
        }
    }
}
