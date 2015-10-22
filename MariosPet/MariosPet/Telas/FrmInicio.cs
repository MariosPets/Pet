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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                FrmLogin login = new FrmLogin();                
                this.Visible = false;
                login.Show();                
            }
        }
    }
}
