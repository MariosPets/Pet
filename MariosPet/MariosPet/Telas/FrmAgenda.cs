using MariosPet.Classes;
using System;
using System.Windows.Forms;

namespace MariosPet.Telas
{
    public partial class FrmAgenda : Form
    {
        ConexaoPadrao conexao;
        Crud.CrudAgendamento crud;
        Funcionario funcionario;
        Cliente cliente;

        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void buttonFuncionario_Click(object sender, EventArgs e)
        {
            /*
            // Busca funcionário
            Estatica.funcionario = null;
            BuscaFuncionario busca = new BuscaFuncionario();
            busca.ShowDialog();
            if (Estatica.funcionario != null)
            {
                funcionario = Estatica.funcionario;
                textBoxFuncionario.Text = funcionario.nome;
            }*/
        }

        private void textBoxFuncionario_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFuncionario.Text != null)
            {
                groupBoxAgendamento.Enabled = true;
            }
            else
            {
                groupBoxAgendamento.Enabled = false;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            groupBoxAgendamento.Enabled = false;
            labelData.Visible = false;
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            labelData.Visible = false;
        }
    }
}
