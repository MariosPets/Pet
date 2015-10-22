using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Telas.FrmMenu menu = new Telas.FrmMenu();
            this.Visible = false;
            menu.Show();
            
        }

        private void btmSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
