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
    public partial class FrmPesquisas : Form
    {
        CrudAnimal CrudAni = new CrudAnimal();
        CrudCliente CrudCli = new CrudCliente();
        CrudFichaClinica CrudFichaCli = new CrudFichaClinica();
        CrudFornecedor CrudForn = new CrudFornecedor();
        CrudFuncionario CrudFunc = new CrudFuncionario();
        CrudLaboratorio CrudLab = new CrudLaboratorio();
        CrudMedicamento CrudMed = new CrudMedicamento();
        CrudProduto CrudProd = new CrudProduto();
        CrudServico CrudServ = new CrudServico();
        CrudVeterinario CrudVet = new CrudVeterinario();

        public FrmPesquisas()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
      
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Telas.FrmMenu menu = new FrmMenu();
            menu.Show();
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (comboBoxTipo.SelectedIndex == 0)
            {                
                dataGridViewPesquisas.DataSource = CrudCli.consultaCliente("Select * from CLIENTE inner join PESSOA on PESSOA.ID_PESSOA = CLIENTE.ID_PESSOA where NOME like '%" + txtPesquisa.Text + "%'");

            }
            if (comboBoxTipo.SelectedIndex == 1)
            {
                dataGridViewPesquisas.DataSource = CrudAni.consultaAnimal("Select * from ANIMAL where NOME like '%" + txtPesquisa.Text + "%'");

            }
            if (comboBoxTipo.SelectedIndex == 2)
            {
                dataGridViewPesquisas.DataSource = CrudFichaCli.consultaFichaClinica("Select * from FICHA_CLINICA where ID_FICHA like '%" + txtPesquisa.Text + "%'");

            }
            if (comboBoxTipo.SelectedIndex == 3)
            {
                dataGridViewPesquisas.DataSource = CrudForn.consultaFornecedor("Select * from FORNECEDOR where ID_PESSOA_JURIDICA like '%" + txtPesquisa.Text + "%'");

            }
            if (comboBoxTipo.SelectedIndex == 4)
            {
                dataGridViewPesquisas.DataSource = CrudFunc.consultaFuncionario("Select * from FUNCIONARIO where ID_PESSOA like '%" + txtPesquisa.Text + "%'");

            }
            if (comboBoxTipo.SelectedIndex == 5)
            {
                dataGridViewPesquisas.DataSource = CrudLab.consultaLaboratorio("Select * from LABORATORIO where ID_PESSOA_JURIDICA like '%" + txtPesquisa.Text + "%'");

            }
            if (comboBoxTipo.SelectedIndex == 6)
            {
                dataGridViewPesquisas.DataSource = CrudMed.consultaMedicamento("Select * from MEDICAMENTO where DESCRICAO like '%" + txtPesquisa.Text + "%'");

            }
            if (comboBoxTipo.SelectedIndex == 7)
            {
                dataGridViewPesquisas.DataSource = CrudProd.consultaProduto("Select * from PRODUTO where DESCRICAO like '%" + txtPesquisa.Text + "%'");

            }
            if (comboBoxTipo.SelectedIndex == 8)
            {
                dataGridViewPesquisas.DataSource = CrudServ.consultaServico("Select * from SERVICO where DESCRICAO like '%" + txtPesquisa.Text + "%'");

            }
            if (comboBoxTipo.SelectedIndex == 9)
            {
                dataGridViewPesquisas.DataSource = CrudVet.consultaVeterinario("Select * from VETERINARIO where NOME like '%" + txtPesquisa.Text + "%'");

            }
        }


    }
}
