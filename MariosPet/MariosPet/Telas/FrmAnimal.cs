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
    public partial class FrmAnimal : Form
    {
        Animal classeAni = new Animal();
        Cliente classeCli = new Cliente();

        CrudCliente CrudCli = new CrudCliente();
        public FrmAnimal()
        {
            InitializeComponent();
        }

        private void btmVoltar_Click(object sender, EventArgs e)
        {
            Telas.FrmMenu frmmenu = new FrmMenu();
            frmmenu.Show();
            Close();
        }

        private void btmLimpar_Click(object sender, EventArgs e)
        {
            txtNomeAnimal.Clear();
            txtPelagemCor.Clear();
            txtRacaPorte.Clear();
            //txtSexo.Clear();
            maskedTxtNascimentoAnimal.Clear();
        }

        public void CopiarParaClasseAnimal()
        {
            classeCli.nome = txtPesquisaCliente.Text;
            //Animal
            classeAni.nome = txtNomeAnimal.Text;
            classeAni.racaPorte = txtRacaPorte.Text;
            classeAni.pelagemCor = txtPelagemCor.Text;
            classeAni.nascimento = maskedTxtNascimentoAnimal.Text;
            classeAni.sexo = radioButtonFemea.Checked;
        }

        private void radioButtonFem_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFemea.Checked == true)
            {
                radioButtonMacho.Checked = false;
            }
            else
            {
                radioButtonMacho.Checked = true;
            }
        }

        private void radioButtonMasc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMacho.Checked == true)
            {
                radioButtonFemea.Checked = false;
            }
            else
            {
                radioButtonFemea.Checked = true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CopiarParaClasseAnimal();


            //Acho q tá certo
            dtgCliente.DataSource = CrudCli.consultaCliente("Select * from CLIENTE inner join PESSOA on PESSOA.ID_PESSOA = CLIENTE.ID_PESSOA where NOME like '%" + txtPesquisaCliente.Text + "%'");

        }

        private void btmSalvar_Click_1(object sender, EventArgs e)
        {
            CopiarParaClasseAnimal();

            CrudAnimal CrudAni = new CrudAnimal();

            CrudAni.inserirAnimal(classeAni);
            CrudCli.inserirCliente(classeCli);


            classeAni.id = Convert.ToInt32(CrudCli.consultaCliente("Select top 1 ID_CLIENTE from CLIENTE order by ID_CLIENTE desc").Rows[0][0].ToString());
        }

        private void dtgCliente_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgCliente.Rows.Count > 0)
            {
                classeAni.idCliente = Convert.ToInt32(dtgCliente.CurrentRow.Cells["ID_PESSOA"].Value.ToString());
            }
        }
    }
}
