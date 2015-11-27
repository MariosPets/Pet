using MariosPet.Crud;
using System;
using System.Data;
using System.Windows.Forms;


namespace MariosPet
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telas.FrmMenu menu = new Telas.FrmMenu();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            
            CrudFuncionario CrudFunc = new CrudFuncionario();
            
            DataTable tabela = CrudFunc.consultaFuncionario("select * from funcionario where apelido = '"+textUsuario.Text+"' and senha = '"+textSenha.Text+"'");
            
            if (tabela.Rows.Count>0)
            {
                Telas.FrmMenu menu = new Telas.FrmMenu();
                Visible = false;
                menu.ShowDialog();
                if (false)
                {
                    Visible = true;
                }
                else
                {
                    Application.Exit();
                }
                
            }
            else {
                textUsuario.Text = "Errado";
            }


        }

        private void btmSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
