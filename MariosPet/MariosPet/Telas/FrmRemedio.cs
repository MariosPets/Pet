using MariosPet.Classes;
using MariosPet.Crud;
using System;
using System.Data;
using System.Windows.Forms;

namespace MariosPet.Telas
{
    public partial class FrmRemedio : Form
    {
        Medicamento classeMed = new Medicamento();
        CrudMedicamento CrudMed = new CrudMedicamento();

        public FrmRemedio()
        {
            InitializeComponent();
            if (Estatica.id != 0)
            {
                CopiarParaFormulario();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMedicamento.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
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

        public void CopiarParaFormulario()
        {
            string sql = "select * from medicamento where id_medicamento = " + Estatica.id.ToString();
            DataTable medicamento = CrudMed.consultaMedicamento(sql);

            //Dados Medicamento
            classeMed.id = Convert.ToInt32(medicamento.Rows[0][0].ToString());
            txtMedicamento.Text = medicamento.Rows[0][1].ToString();
            nudQuantidade.Text = medicamento.Rows[0][2].ToString();
            nudMinimo.Text = medicamento.Rows[0][3].ToString();
            nudMaximo.Text = medicamento.Rows[0][4].ToString();
        }
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            CopiarParaClasseMedicamento();

            if (Estatica.id != 0)
            {
                CrudMed.alteraMedicamento(classeMed);
                Estatica.id = 0;
            }
            else
            {
                CrudMed.inserirMedicamento(classeMed);
            }            
        }
    }
}
