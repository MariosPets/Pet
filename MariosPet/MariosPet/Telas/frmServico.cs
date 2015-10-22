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
    public partial class FrmServico : Form
    {
        Servico classeServ = new Servico();
        public FrmServico()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtServico.Clear();
            mstPreco.Clear();
        }

        public void CopiarParaClasseServico()
        {
            classeServ.descricao = txtServico.Text;
            classeServ.preco = Convert.ToDouble(mstPreco.Text);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CopiarParaClasseServico();

            CrudServico CrudServ = new CrudServico();

            CrudServ.inserirServico(classeServ);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Telas.FrmMenu frmmenu = new FrmMenu();
            frmmenu.Show();
            Close();
        }
    }
}
