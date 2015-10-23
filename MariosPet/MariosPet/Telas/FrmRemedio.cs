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
    public partial class FrmRemedio : Form
    {
        Medicamento classeMed = new Medicamento();
        public FrmRemedio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMedicamento.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Telas.FrmMenu menu = new FrmMenu();
            menu.Show();
            Close();
        }

        public void CopiarParaClasseMedicamento()
        {
            //Medicamento
            classeMed.descricao = txtMedicamento.Text;
            classeMed.quantidade = Convert.ToInt32(nudQuantidade.Text);
            classeMed.minimoEmEstoque = Convert.ToInt32(nudMinimo.Text);
            classeMed.maximoEmEstoque = Convert.ToInt32(nudMaximo.Text);
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            CopiarParaClasseMedicamento();

            CrudMedicamento CrudMed = new CrudMedicamento();

            CrudMed.inserirMedicamento(classeMed);
        }
    }
}
