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
    public partial class FrmLaboratorio : Form
    {
        Endereco classeEnd = new Endereco();
        Laboratorio classeLab = new Laboratorio();
        public FrmLaboratorio()
        {
            InitializeComponent();
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
            Telas.FrmMenu frmmenu = new FrmMenu();
            frmmenu.Show();
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

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            CopiarParaClasseLaboratorio();

            CrudLaboratorio CrudLab = new CrudLaboratorio();
            CrudEndereco CrudEnd = new CrudEndereco();

            CrudEnd.inserirEndereco(classeEnd);

            classeLab.idEndereco = Convert.ToInt32(CrudEnd.consultaEndereco("select 1 ID_ENDERECO from ENDERECO order by ID_ENDERECO desc").Rows[0][0].ToString());

            CrudLab.inserirLaboratorio(classeLab);
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
