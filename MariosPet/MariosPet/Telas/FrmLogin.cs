using MariosPet.Classes;
using MariosPet.Crud;
using System;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Text;
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
            try
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
                else
                {
                    textUsuario.Text = "Errado";
                }
            }
            catch {
                try
                {
                    OpenFileDialog dgl = new OpenFileDialog();
                    dgl.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
                    dgl.FilterIndex = 0;

                    if (dgl.ShowDialog() == DialogResult.OK)
                    {
                        string sql = "restore database MARIOS_PET from disk = '" + dgl.FileName + "' with replace;";
                        SqlCommand comando = new SqlCommand(sql, new SqlConnection(@"server = .\sqlexpress; integrated security = true;"));
                        new SqlConnection(@"server = .\sqlexpress; integrated security = true;").Open();
                        comando.ExecuteNonQuery();
                    }
                }
                catch {
                    Application.Exit();
                }
                
                
            }
            
            


        }

        private void btmSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
